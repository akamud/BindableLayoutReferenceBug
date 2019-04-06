using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BindableLayoutReferenceBug
{
    public class Message
    {
        public ObservableCollection<string> Options { get; set; }

        public Message()
        {
            Options = new ObservableCollection<string>
            {
                "Message 1",
                "Message 2",
                "Message 3",
            };
        }
    }
}
