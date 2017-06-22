using System;
using System.Collections.Generic;

namespace pfs.Controllers.Resources
{
    public class ActionResouce
    {
        public ActionResouce()
        {
            
        }
        public ActionResouce(string Action)
        {
            switch(Action)
            {
                case "BUY" :
                {
                    this.Id =1;
                    this.Name = Action;       
                };
                break;
                case "SELL" :
                {
                    this.Id =2;
                    this.Name = Action;       
                };
                break;
                case "UPDATE" :
                {
                    this.Id =3;
                    this.Name = Action;       
                };
                break;
            }
        }
        public int Id { get; set; }
        public string Name { get; set; }

        internal ICollection<ActionResouce> GetActionType()
        {
            ICollection<ActionResouce> actionResouces = new List<ActionResouce>();
            ActionResouce BAction = new ActionResouce("BUY");
            actionResouces.Add(BAction);

            ActionResouce SAction = new ActionResouce("SELL");
            actionResouces.Add(SAction);
            ActionResouce UAction = new ActionResouce("UPDATE");
            actionResouces.Add(UAction);
            return actionResouces;
        }
    }
}