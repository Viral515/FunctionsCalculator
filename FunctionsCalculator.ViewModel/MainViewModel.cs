using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using FunctionsCalculator.Model;
using GalaSoft.MvvmLight.Command;

namespace FunctionsCalculator.ViewModel
{
    /// <summary>
    /// Связывает View представление с Model
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Выбранная функция
        /// </summary>
        private Function _selectedFunction;

        /// <summary>
        /// Коллекция функций
        /// </summary>
        public ObservableCollection<Function> _functions { get; set; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public MainViewModel()
        {
            _functions = new ObservableCollection<Function>
            {
                new Function("Линейная",
                    new ObservableCollection<double>{1,2,3,4,5}, 1, 0),
                new Function("Квадратичная",
                    new ObservableCollection<double>{10,20,30,40,50}, 2, 1),
                new Function("Кубическая",
                    new ObservableCollection<double>{100,200,300,400,500}, 3, 2),
                new Function("4-ой степени",
                    new ObservableCollection<double>{1000,2000,3000,4000,5000}, 4, 3),
                new Function("5-ой степени",
                    new ObservableCollection<double>{10000,20000,30000,40000,50000}, 5, 6)
            };
            SelectedFunction = _functions.First();
            AddCalculateComand = new RelayCommand<object>(CalculateResult);
        }

        /// <summary>
        /// Возвращает или задаёт выбранную функцию
        /// </summary>
        public Function SelectedFunction
        {
            get => _selectedFunction;
            set
            {
                _selectedFunction = value;
            }
        }

        /// <summary>
        /// Команда добавления рассчёта функции f(x,y) в коллекцию
        /// </summary>
        public ICommand AddCalculateComand { get; }

        /// <summary>
        /// Функция рассчёта результата функции f(x,y)
        /// </summary>
        /// <param name="parameter"></param>
        public void CalculateResult(object parameter)
        {
            SelectedFunction.CalculateResult();
        }
    }
}
