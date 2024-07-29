using System.ComponentModel;
using System.Runtime.CompilerServices;
using Puntos1y2C4030349.Models;


namespace Puntos1y2C4030349.View
{
    internal class PuntosViewModel : INotifyPropertyChanged
    {

        private double? _a1;
        private double? _b1;
        private double? _a2;
        private double? _b2;

        private double? _distancia;

        public double? A1
        {
            get => _a1;
            set
            {
                _a1 = value;
                OnPropertyChanged();
                CalcularDistancia();
            }
        }

        public double? B1
        {
            get => _b1;
            set
            {
                _b1 = value;
                OnPropertyChanged();
                CalcularDistancia();
            }
        }

        public double? Distancia
        {
            get => _distancia;
            private set
            {
                _distancia = value;
                OnPropertyChanged();
            }
        }

        public double? A2
        {
            get => _a2;
            set
            {
                _a2 = value;
                OnPropertyChanged();
                CalcularDistancia();
            }
        }

        public double? B2
        {
            get => _b2;
            set
            {
                _b2 = value;
                OnPropertyChanged();
                CalcularDistancia();
            }
        }

        private void CalcularDistancia()
        {
            var point1 = new Puntos { A = A1?? 0, B = B1 ?? 0 };
            var point2 = new Puntos { A = A2 ?? 0, B = B2 ?? 0 };
            Distancia = Puntos.CalcularDistancia(point1, point2);
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
