using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace danceEN
{
    public partial class ChoreografienViewModel
    {
        public ObservableCollection<Choreo> CollectionChoreografien { get; set; }

        public ChoreografienViewModel()
        {
            CollectionChoreografien = new ObservableCollection<Choreo> { };

        }

        public void addChoreo(string newName)
        {
            CollectionChoreografien.Add(new Choreo(newName));
        }

    }
}

public struct Choreo
{
   public string ChoreoName { get; set; }

    public Choreo(string Name)
    {
        this.ChoreoName = Name;
    }
}
