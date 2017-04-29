namespace ACMBot.Messages
{
    public class Messages
    {
        private Messages()
        {
            
        }

        /// <summary>
        /// Create welcome message text
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string Welcome(string name)
        {
            return $@"**Hola {name}, bienvenido a la ACM USAL!**

Se te ha dado de alta en dos grupos, este y ACM-Offtopic.

Este grupo es para cosas importantes, que todos debemos saber.
Estaría bien que dejaras este grupo con notificaciones.

El otro grupo es para que hables siempre que quieras sobre cualquier
cosa que se te ocurra, y lo puedes silenciar si te molesta demasiado.

Si necesitas saber cuales son los grupos, lo puedes hacer con:
/list

Encantado de tenerte por aquí!";
        }

        /// <summary>
        /// Help message
        /// </summary>
        /// <returns></returns>
        public static string Help()
        {
            return @"Este bot permite añadirte a los grupos SIG de ACM.

Lista de comandos:

**/list** Lista los grupos

**/help** Muestra este mensaje";
        }

        /// <summary>
        /// Show all groups
        /// </summary>
        /// <returns></returns>
        public static string List()
        {
            return $@"ACM-SIGNET [entrar]({Private.SIGNET})";
        }

        /// <summary>
        /// Show the bot description
        /// </summary>
        /// <returns></returns>
        public static string Description()
        {
            return @"Bot creado por @suudo con C# y el MS Bot Framework

[GitHub](https://github.com/ganchito55/ACMUsalBot) v1";
        }

    }
}