using ProductsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using ProductsApp.ServiceReference;
using System.Net.Http;

namespace ProductsApp.Controllers
{
    public class PersonsController : ApiController
    {
        ServiceReference.ServiceClient serviceClient = new ServiceClient();
        
        [HttpGet]
        [Route("api/products")]

        public Person[] GetAllPeople()
        {
            Person[] peopleList;
            peopleList = serviceClient.GetAllPerson();
            return peopleList;
        }


        [HttpGet]
        [Route("api/products/{id}")]
        
        public Person GetPerson(int id)
        {
            Person[] peopleList;
            peopleList = serviceClient.GetAllPerson();
            return peopleList[id];
        }


        [HttpPost]
        [Route("api/products")]
        
        public HttpResponseMessage AddPerson(Person person)
        {
            serviceClient.AddPerson(person);
            var response = Request.CreateResponse<Person>(HttpStatusCode.Created, person);
            return response;
        }
        
        
        [HttpPut]
        [Route("api/products")]
        
        public bool UpdatePerson(int id,Person person)
        {
            
            var response=serviceClient.UpdatePerson(id,person);
            return response;
        }
        
        
        [HttpDelete]
        [Route("api/products/{id}")]
        
        public bool DeletePerson(int id)
        {
            var response = serviceClient.DeletePerson(id);
            return response;
        }
    }
}
