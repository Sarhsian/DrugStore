using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugStoreWF
{
    public class Client
    {
     
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string User { get; set; }


        public override string ToString() =>
        $"Name - {Name} Surname - {Surname} Age - {Login} Password {Password} ";
    }

    public class Client2 : ObservableCollection<Client>
    { }

    public class Clients : BindingList<Client>
    {

    }
}
