namespace MVC.Controllers
{
    public class SMSBuilder
    {
        public string type { get; set; }
        public string text;
        public string From { get; internal set; }
        public string To { get; internal set; }
    }
}