using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using pfs.Controllers.Resources;

namespace pfs.Controllers
{
    [Route("api/[controller]")]
    public class StockController :Controller
    {
        public IActionResult GetActionType()
        {
            ActionResouce actionResouce = new ActionResouce();
            ICollection<ActionResouce> actionResources = actionResouce.GetActionType();

            return Json(actionResources);
        }

        public IActionResult AddStock(StockResource stockResouce)
        {
            return Ok(stockResouce);
        }
    }
}