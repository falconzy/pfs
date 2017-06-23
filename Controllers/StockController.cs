using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using pfs.Controllers.Resources;

namespace pfs.Controllers
{
   
    public class StockController :Controller
    {
        private readonly IMapper _mapper;
        public StockController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        [Route("api/stock/GetActionType")]
        public IActionResult GetActionType()
        {
            ActionResouce actionResouce = new ActionResouce();
            ICollection<ActionResouce> actionResources = actionResouce.GetActionType();
            
            return Json(actionResources);
        }
        [HttpPost]
        [Route("api/stock/StockUpdate")]
        public IActionResult StockUpdate(StockResource stockResouce)
        {   //map stockResource to Stock
            //map stockResource to stock transction

            if(stockResouce.Acion=="BUY")
            {

            }
            if(stockResouce.Acion=="SELL")
            {
                
            }
            if(stockResouce.Acion=="UPDATE")
            {
                
            }
            else{
                return BadRequest("Action Not Found.");
            }
            //update to stock table;
            //add to transction table;
            return Ok(stockResouce);
        }
    }
}