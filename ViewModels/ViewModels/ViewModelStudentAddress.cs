using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModels.Models;

namespace ViewModels.ViewModels
{
    public class ViewModelStudentAddress
    {
        //Helemaal niets meer dan een domme klasse 
        // D:

        public Student Student { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Schoolname { get; set; }
    }
}
