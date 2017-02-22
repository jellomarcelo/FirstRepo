using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGITProject.Class.Resource.Interface
{
    public class IResource
    {
        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleInitial { get; set; }
        DateTime DateOfBirth { get; set; }


    }
}
