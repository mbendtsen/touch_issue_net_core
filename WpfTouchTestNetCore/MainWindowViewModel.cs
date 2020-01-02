using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfScrollTestNetCore
{
    public class MainWindowViewModel
    {
        public IEnumerable<string> Items { get; }
        public ObservableCollection<string> Events { get; }


        public MainWindowViewModel()
        {
            Items = Generate(100).ToList();
            Events = new ObservableCollection<string>();
        }

        public void AddEvent(string str)
        {
            Events.Insert(0, $"{DateTime.Now.ToString("hh:mm:ss")}\t{str}");
        }

        private IEnumerable<string> Generate(int count)
        {
            for(var i = 0; i < count; i++)
            {
                yield return Guid.NewGuid().ToString();
            }
        }
    }
}
