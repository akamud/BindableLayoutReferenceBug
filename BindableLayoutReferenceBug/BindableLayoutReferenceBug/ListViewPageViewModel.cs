using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace BindableLayoutReferenceBug
{
    public class ListViewPageViewModel
    {
        public ObservableCollection<Message> Items { get; set; }
        public ICommand ShowMessageCommand { get; set; }

        public ListViewPageViewModel()
        {
            Items = new ObservableCollection<Message>
            {
                new Message(),
                new Message(),
                new Message(),
            };

            ShowMessageCommand = new Command<string>(msg => ShowMessage(msg));
        }

        public void ShowMessage(string msg)
            => Debug.WriteLine($"Message clicked : {msg}");
    }
}
