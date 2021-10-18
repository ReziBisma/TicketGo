using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TicketGo.Controllers
{
    public class Ticketgocs : Controller
    {

        public string Index()
        {
            return "This is my default action...";
        } 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}