using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiDemoDataBinding.Models
{
    public class Produto : INotifyPropertyChanged
    {
        private string nome;
        private decimal preco;
        private int stock;

        public string Nome
        {
            get => nome;
            set
            {
                nome = value;
                OnPropertyChanged();
            }
        }

        public decimal Preco
        {
            get => preco;
            set
            {
                preco = value;
                OnPropertyChanged();
            }
        }
        public int Stock
        {
            get => stock;
            set
            {
                stock = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName]
        string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}