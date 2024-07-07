using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace danceEN
{
    public partial class TeilnehmerViewModel
    {
        public ObservableCollection<TeilnehmerStruct> CollectionTeilnehmer { get; set; }

        public TeilnehmerViewModel()
        {
            CollectionTeilnehmer = new ObservableCollection<TeilnehmerStruct> { };

        }

        public void addTeilnehmer(string newName)
        {
            CollectionTeilnehmer.Add(new TeilnehmerStruct
            {
                Name = newName
            });
        }

        public List<TeilnehmerStruct> GetAll()
        {
            var TeilnehmerStructList = new List<TeilnehmerStruct>();

            foreach (var item in CollectionTeilnehmer)
            {
                TeilnehmerStructList.Add(item);
            }

            return TeilnehmerStructList;
        }

        public ObservableCollection<TeilnehmerStruct> GetObservableCollection()
        {
            return CollectionTeilnehmer;
        }
    }
}