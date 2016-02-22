using ServiceReader.ServiceReference;
using PersonDO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.Configuration;

namespace ServiceReader
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReader.ServiceReference.ServiceClient sc = new ServiceClient();
            
            Person person = new Person();
            BasicHttpBinding basicbinding = new BasicHttpBinding();
            person=sc.someMethod();
            //person = servicePerson.someMethod();
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Name);
            Console.ReadLine();
        }
    }
}
