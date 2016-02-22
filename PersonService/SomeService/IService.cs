using PersonDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PersonService
{

    [ServiceContract]
    public interface IService
    {
      
      [OperationContract]
      List<Person> GetAllPerson();
      
      [OperationContract]
      bool AddPerson(Person person);
      
      [OperationContract]
      bool UpdatePerson(int id, Person person);

      [OperationContract]
      bool DeletePerson(int id);
     }
    
}
