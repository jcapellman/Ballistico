using System.ComponentModel;

namespace Ballistico.UWP.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private int weight;

        public int Weight
        {
            get => weight;

            set
            {
                weight = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Weight)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}