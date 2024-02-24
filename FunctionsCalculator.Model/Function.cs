using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;

namespace FunctionsCalculator.Model
{
    /// <summary>
    /// Описывает функцию
    /// </summary>
    public class Function
    {
        /// <summary>
        /// Имя функции
        /// </summary>
        private string _functionName;

        /// <summary>
        /// Коэффициент а
        /// </summary>
        private double _coefficientA;
        
        /// <summary>
        /// Коэффициент b
        /// </summary>
        private double _coefficientB;

        /// <summary>
        /// Коэффициент c
        /// </summary>
        private double _coefficientC;

        /// <summary>
        /// Коэффициент x
        /// </summary>
        private double _coefficientX;

        /// <summary>
        /// Коэффициент y
        /// </summary>
        private double _coefficientY;

        /// <summary>
        /// Коллекция значений коэффициента c
        /// </summary>
        private ObservableCollection<double>? _coefficientCRange;

        /// <summary>
        /// Коллекция объектов хранящих результаты рассчётов функции f(x,y)
        /// </summary>
        private ObservableCollection<CalculateResults>? _results;

        /// <summary>
        /// Степень коэффициента x
        /// </summary>
        private int _coefficientXpow;

        /// <summary>
        /// Степень коэффициента y
        /// </summary>
        private int _coefficientYpow;

        /// <summary>
        /// Задаёт и возвращает имя функции
        /// </summary>
        public string FunctionName
        {
            get => _functionName;
            set { _functionName = value; }
        }

        /// <summary>
        /// Задаёт и возвращает коэффициент a
        /// </summary>
        public double CoefficientA
        {
            get => _coefficientA;
            set { _coefficientA = value; }
        }

        /// <summary>
        /// Задаёт и возвращает коэффициент b
        /// </summary>
        public double CoefficientB
        {
            get => _coefficientB;
            set { _coefficientB = value; }
        }

        /// <summary>
        /// Задаёт и возвращает коэффициент c
        /// </summary>
        public double CoefficientC
        {
            get => _coefficientC;
            set { _coefficientC = value; }
        }

        /// <summary>
        /// Задаёт и возвращает степень коэффициента x
        /// </summary>
        public int CoefficientXpow
        {
            get => (int)_coefficientXpow; 
            set { _coefficientXpow = value; }
        }

        /// <summary>
        /// Задаёт и возвращает степень коэффициента y
        /// </summary>
        public int CoefficientYpow
        {
            get => (int)_coefficientYpow;
            set { _coefficientYpow = value; }
        }

        /// <summary>
        /// Задаёт и возвращает коэффициент x
        /// </summary>
        public double CoefficientX
        {
            get => _coefficientX;
            set
            {
                _coefficientX = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает коэффициент y
        /// </summary>
        public double CoefficientY
        {
            get => _coefficientY;
            set
            {
                _coefficientY = value;
            }
        }

        /// <summary>
        /// Задаёт и возвращает коллекцию значений коэффициента c
        /// </summary>
        public ObservableCollection<double> CoefficientCRange
        {
            get => _coefficientCRange;
            set { _coefficientCRange = value; }
        }

        /// <summary>
        /// Задаёт и возвращает коллекцию объектов хранящих результаты рассчётов функции f(x,y)
        /// </summary>
        public ObservableCollection<CalculateResults> Results
        {
            get => _results;
            set { _results = value; }
        }

        /// <summary>
        /// Создаёт экземпляр <see cref="Function">
        /// </summary>
        /// <param name="name">Имя функции</param>
        /// <param name="range">Коллекция значений коэффициента c</param>
        /// <param name="XPow">Степень коэффициента x</param>
        /// <param name="YPow">Степень коэффициента y</param>
        public Function(string name, ObservableCollection<double> range, int XPow, int YPow)
        {
            FunctionName = name;
            CoefficientA = 1.0;
            CoefficientB = 1.0;
            CoefficientC = range[0];
            CoefficientCRange = range;
            Results = new ObservableCollection<CalculateResults>();
            CoefficientXpow = XPow;
            CoefficientYpow = YPow;
        }

        /// <summary>
        /// Рассчитывает значение функции f(x,y) и добавляет новую запись в 
        /// коллекцию объектов хранящих результаты рассчётов
        /// </summary>
        public void CalculateResult()
        {
            double result = CoefficientA * Math.Pow(CoefficientX, CoefficientXpow) + CoefficientB
                * Math.Pow(CoefficientY, CoefficientYpow) + CoefficientC;
            CalculateResults newResult = new CalculateResults(CoefficientX, CoefficientY, result, 
                new RelayCommand<CalculateResults>(CalculateRow));
            Results.Add(newResult);
        }

        /// <summary>
        /// Перерассчитывает значение функции f(x,y)
        /// </summary>
        /// <param name="result">Объект класса CalculateResults, который необходимо 
        /// пересчитать</param>
        public void CalculateRow(CalculateResults result)
        {
            int index = Results.IndexOf(result);
            if (index == -1) { return; }
            double x = Results[index].CoefficientX;
            double y = Results[index].CoefficientY;
            Results[index].CalculationResult = CoefficientA * Math.Pow(x, CoefficientXpow) 
                + CoefficientB * Math.Pow(y, CoefficientYpow) + CoefficientC; ;
        }
    }
}
