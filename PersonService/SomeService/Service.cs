using PersonDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PersonService
{
   
    public class Service : IService
    {
        List<Person> personList = new List<Person>
            {
                new Person(){ Age=20, Name="Chandan"},
                new Person(){ Age=25, Name="NIkhil"},
                new Person(){ Age=27, Name="Pavan"},
                new Person(){ Age=29, Name="Suresh"}
            };
        

        public List<Person> GetAllPerson()
        {
            
            return personList; 
        }
        
        public bool AddPerson(Person person)
        {
            var response = false;
            try
            {
                personList.Add(person);
                response = true;
            }
            catch (Exception e)
            {

            }
            return response;
            
        }

        public bool UpdatePerson(int id, Person person)
        {
            var response = false;
            try
            {
                personList[id] = person;
                response = true;
            } 
            catch(Exception e)
            {

            }
            return response;
        }

        public bool DeletePerson(int id)
        {
            var response = false;
           
            try
            {
                personList.RemoveAt(id);
                response = true;
            }
            catch (Exception e)
            {

            }
            return response;
        }
    }
}
