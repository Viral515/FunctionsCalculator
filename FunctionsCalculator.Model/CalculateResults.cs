using System.ComponentModel;
using System.Windows.Input;

namespace FunctionsCalculator.Model
{
    /// <summary>
    /// Описывает результаты рассчёта функции f(x,y) 
    /// </summary>
    public class CalculateResults : INotifyPropertyChanged
    {
        /// <summary>
        /// Коэффициент x
        /// </summary>
        private double _coefficientX;

        /// <summary>
        /// Коэффициент y
        /// </summary>
        private double _coefficientY;

        /// <summary>
        /// Результат рассчёта функции
        /// </summary>
        private double _calculationResult;

        /// <summary>
        /// Команда для рассчёта функции
        /// </summary>
        private ICommand _calculateCommand;

        /// <summary>
        /// Возвращает или задаёт коэффициент x
        /// </summary>
        public double CoefficientX
        {
            get { return _coefficientX; }
            set 
            { 
                _coefficientX = value;
                CalculateCommand.Execute(this);
                PropertyChanged?.Invoke(this, 
                    new PropertyChangedEventArgs(nameof(CoefficientX)));
            }
        }

        /// <summary>
        /// Возвращает или задаёт коэффициент y
        /// </summary>
        public double CoefficientY
        {
            get { return _coefficientY; }
            set 
            { 
                _coefficientY = value;
                CalculateCommand.Execute(this);
                PropertyChanged?.Invoke(this, 
                    new PropertyChangedEventArgs(nameof(CoefficientY)));
            }
        }

        /// <summary>
        /// Возвращает или задаёт результат рассчёта функции
        /// </summary>
        public double CalculationResult
        {
            get { return _calculationResult; }
            set 
            { 
                _calculationResult = value;
                PropertyChanged?.Invoke(this, 
                    new PropertyChangedEventArgs(nameof(CalculationResult)));
            }
        }

        /// <summary>
        /// Возвращает или задаёт команду для рассчёта функции
        /// </summary>
        public ICommand CalculateCommand
        {
            get { return _calculateCommand; }
            set { _calculateCommand = value; }
        }

        /// <summary>
        /// Создаёт экземпляр <see cref="CalculateResults">
        /// </summary>
        /// <param name="x">Коэффициент x</param>
        /// <param name="y">Коэффициент y</param>
        /// <param name="result">Результат рассчёта функции</param>
        /// <param name="calculateCommand">Команда для рассчёта функции</param>
        public CalculateResults(double x, double y, double result, ICommand calculateCommand)
        {
            CalculateCommand = calculateCommand;
            CoefficientX = x;
            CoefficientY = y;
            CalculationResult = result;
        }

        /// <summary>
        /// Событие изменения свойства класса
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
