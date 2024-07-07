using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace danceEN
{
    public struct SongLink
    {
        string link;
        public string LinkText { get; set; }
        public ICommand TapCommand => new Command(open_web);

        public SongLink(string link, string linkText)
        {
            this.link = link;
            LinkText = linkText;
        }

        private void open_web()
        {
            if (!string.IsNullOrEmpty(link))
            {
                try{
                    Launcher.OpenAsync(link);
                }
                catch {  }
                
            }
            
        }
    }
}
