using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PostAPIApplication.Models;



namespace PostAPIApplication.Controllers
{
   
    [Route("api/[Controller]")]
    public class PeopleInformationController : Controller
    {
         public List<PeopleInfo> lst = new List<PeopleInfo>();
        [HttpPost]
        public List<PeopleInfo> Post([FromBody] PeopleInfo m)
        {
         List<PeopleInfo> l =  new List<PeopleInfo>();
         //lst = new List<PeopleInfo>();
            if(m != null)
            {
                l.Add(m);
            }  
            lst = l;
            return l;
        }

        [HttpGet]
        public List<PeopleInfo> GetAll(List<PeopleInfo> l)
        {
            return l;
           
        }
    }
    
       
}

