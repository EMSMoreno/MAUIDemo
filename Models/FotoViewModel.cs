using MauiDemo.Models;
using System.Collections.ObjectModel;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }
        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }
        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto() { Nome="Andrómeda", ImagemUrl="galaxia1.jpg" },
                new Foto() { Nome="Via Láctea", ImagemUrl="galaxia2.jpg" },
                new Foto() { Nome="Universo", ImagemUrl="galaxia3.jpg" },
                new Foto() { Nome="Galáxia", ImagemUrl="galaxia4.jpg" },
                new Foto() { Nome="Sombrero", ImagemUrl="galaxia5.jpg" },
                new Foto() { Nome="Andrómeda", ImagemUrl="galaxia1.jpg" },
                new Foto() { Nome="Via Láctea", ImagemUrl="galaxia2.jpg" },
                new Foto() { Nome="Universo", ImagemUrl="galaxia3.jpg" },
                new Foto() { Nome="Galáxia", ImagemUrl="galaxia4.jpg" },
                new Foto() { Nome="Sombrero", ImagemUrl="galaxia5.jpg" },
                new Foto() { Nome="Andrómeda", ImagemUrl="galaxia1.jpg" },
                new Foto() { Nome="Via Láctea", ImagemUrl="galaxia2.jpg" },
                new Foto() { Nome="Universo", ImagemUrl="galaxia3.jpg" },
                new Foto() { Nome="Galáxia", ImagemUrl="galaxia4.jpg" },
                new Foto() { Nome="Sombrero", ImagemUrl="galaxia5.jpg" }
            };
        }
    }
}
