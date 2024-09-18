using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Windows.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private const double PI = 3.1415926535897931;

        private double _radio;
        public double Radio
        {
            get => _radio;
            set => SetProperty(ref _radio, value);
        }

        private double _area;
        public double Area
        {
            get => _area;
            set => SetProperty(ref _area, value);
        }

        public ICommand CalcularAreaCommand { get; }
        public ICommand LimpiarCamposCommand { get; }

        public MainViewModel()
        {
            CalcularAreaCommand = new RelayCommand(CalcularArea);
            LimpiarCamposCommand = new RelayCommand(LimpiarCampos);
        }

        private void CalcularArea()
        {
            if (Radio <= 0)
            {
                // Si el radio no es positivo, no hacer el cálculo.
                Area = 0;
                return;
            }

            Area = PI * Radio * Radio;
        }

        private void LimpiarCampos()
        {
            Radio = 0;
            Area = 0;
        }
    }
}
