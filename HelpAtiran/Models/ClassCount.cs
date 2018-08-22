namespace ClassModels
{
   public class ClassCount
    {
        public int ResposeMessage { get; set; }
        public int ToatalCount { get; set; }

        public ClassCount(int ResposeMessage)
        {
            this.ResposeMessage = ResposeMessage;
        }
    }
}
