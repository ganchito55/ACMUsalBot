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

Se te ha dado de alta en dos grupos, ACM-Offtopic y ACM USAL.

ACM USAL es para cosas importantes, que todos debemos saber.
Estaría bien que dejaras este grupo con notificaciones.

ACM-Offtopic es para que hables siempre que quieras sobre cualquier
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
            return $@"ACM-SIGNET [entrar]({Private.SIGNET})

ACM-JOBS [entrar]({Private.JOBS})

ACM-SIGAI [entrar]({Private.SIGIA})

ACM-SIGDEV [entrar]({Private.SIGDEV})

ACM-SIGSECURITY [entrar]({Private.SIGSECURITY})";
        }

        /// <summary>
        /// Show the bot description
        /// </summary>
        /// <returns></returns>
        public static string Description()
        {
            return @"Bot creado por @suudo con C# y MS Bot Framework

[GitHub](https://github.com/ganchito55/ACMUsalBot) v1.1";
        }

        public static string Staff()
        {
            return @"La junta de ACM 2018-2019

Presidente: Guillermo Reguera - @heymechanic

Vicepresidente: Juan Carlos Martin - @Heartless_Lion

Tesorero: Arturo Vazquez - @arzurr

Secretario: Rodrigo Zevallos - @TheNomo3000";
        }
    }
}