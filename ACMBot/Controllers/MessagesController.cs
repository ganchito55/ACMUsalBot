using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Bot.Connector;

namespace ACMBot
{
    [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        ///     POST: api/Messages
        ///     Receive a message from a user and reply to it
        /// </summary>
        public async Task<HttpResponseMessage> Post([FromBody] Activity activity)
        {
            // Only works in ACM Offtopic
            if (activity.Conversation.Id == Private.ACMOfftopic)
            {
                if (activity.Type == ActivityTypes.Message)
                {
                    var connector = new ConnectorClient(new Uri(activity.ServiceUrl));

                    //Filter bot messages
                    string replyString = null;
                    switch (activity.Text)
                    {
                        case "/list":
                            replyString = Messages.Messages.List();
                            break;
                        case "/description":
                            replyString = Messages.Messages.Description();
                            break;
                        case "/help":
                            replyString = Messages.Messages.Help();
                            break;
                    }

                    // return our reply to the user
                    var reply = activity.CreateReply($@"{replyString}");
                    await connector.Conversations.ReplyToActivityAsync(reply);
                }
                else
                {
                    HandleSystemMessage(activity);
                }
            }

            var response = Request.CreateResponse(HttpStatusCode.OK);
            return response;
        }

        private Activity HandleSystemMessage(Activity message)
        {
            var connector = new ConnectorClient(new Uri(message.ServiceUrl));

            if (message.Type == ActivityTypes.DeleteUserData)
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == ActivityTypes.ConversationUpdate)
            {
                // Handle conversation state changes, like members being added and removed
                // Use Activity.MembersAdded and Activity.MembersRemoved and Activity.Action for info
                // Not available in all channels
                if (message.MembersAdded.Any())
                    foreach (var account in message.MembersAdded)
                    {
                        var response = message.CreateReply(Messages.Messages.Welcome(account.Name));
                        connector.Conversations.ReplyToActivityAsync(response);
                    }
            }
            else if (message.Type == ActivityTypes.ContactRelationUpdate)
            {
                // Handle add/remove from contact lists
                // Activity.From + Activity.Action represent what happened
            }
            else if (message.Type == ActivityTypes.Typing)
            {
                // Handle knowing tha the user is typing
            }
            else if (message.Type == ActivityTypes.Ping)
            {
            }

            return null;
        }
    }
}