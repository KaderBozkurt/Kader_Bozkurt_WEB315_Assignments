namespace KaderBozkurtChat.Shared
{
    
    /// Stores shared names used in both client and hub
  
    public static class Messages
    {
       
        /// Event name when a message is received
      
        public const string RECEIVE = "ReceiveMessage";

      
        /// Name of the Hub method to register a new user
      
        public const string REGISTER = "Register";

     
        /// Name of the Hub method to send a message
    
        public const string SEND = "SendMessage";

    }
}