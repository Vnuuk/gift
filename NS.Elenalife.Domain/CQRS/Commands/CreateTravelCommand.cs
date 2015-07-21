using System.Collections.Generic;
using System.Web;
using Incoding.CQRS;

namespace NS.Elenalife.Domain.CQRS.Commands
{
    public class CreateTravelCommand : CommandBase
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<HttpPostedFileBase> Media { get; set; }

        public override void Execute()
        {
            
        }
    }
}