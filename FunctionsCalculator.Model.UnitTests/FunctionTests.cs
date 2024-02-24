using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Collections.ObjectModel;

namespace FunctionsCalculator.Model.UnitTests
{
    [TestFixture]
    public class FunctionTests
    {
        // Тесты имени функции
        [Test(Description = "Позитивный тест сеттера имени функции")]
        public void FunctionName_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = "Квадратичная";
            function.FunctionName = expected;

            // Act
            var actual = function.FunctionName;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера имени функции")]
        public void FunctionName_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = "Квадратичная";
            function.FunctionName = expected;

            // Act
            var actual = function.FunctionName;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента a
        [Test(Description = "Позитивный тест сеттера коэффициента a")]
        public void CoefficientA_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientA = expected;

            // Act
            var actual = function.CoefficientA;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента a")]
        public void CoefficientA_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientA = expected;

            // Act
            var actual = function.CoefficientA;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента b
        [Test(Description = "Позитивный тест сеттера коэффициента b")]
        public void CoefficientB_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientB = expected;

            // Act
            var actual = function.CoefficientB;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента b")]
        public void CoefficientB_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientB = expected;

            // Act
            var actual = function.CoefficientB;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента c
        [Test(Description = "Позитивный тест сеттера коэффициента c")]
        public void CoefficientC_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientC = expected;

            // Act
            var actual = function.CoefficientC;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента c")]
        public void CoefficientC_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientC = expected;

            // Act
            var actual = function.CoefficientC;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты степени коэффициента x
        [Test(Description = "Позитивный тест сеттера степени коэффициента x")]
        public void CoefficientXpow_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientXpow = expected;

            // Act
            var actual = function.CoefficientXpow;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера степени коэффициента x")]
        public void CoefficientXpow_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientXpow = expected;

            // Act
            var actual = function.CoefficientXpow;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты степени коэффициента y
        [Test(Description = "Позитивный тест сеттера степени коэффициента y")]
        public void CoefficientYpow_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientYpow = expected;

            // Act
            var actual = function.CoefficientYpow;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера степени коэффициента y")]
        public void CoefficientYpow_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientYpow = expected;

            // Act
            var actual = function.CoefficientYpow;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента x
        [Test(Description = "Позитивный тест сеттера коэффициента x")]
        public void CoefficientX_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientX = expected;

            // Act
            var actual = function.CoefficientX;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента x")]
        public void CoefficientX_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientX = expected;

            // Act
            var actual = function.CoefficientX;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента y
        [Test(Description = "Позитивный тест сеттера коэффициента y")]
        public void CoefficientY_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientY = expected;

            // Act
            var actual = function.CoefficientY;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента y")]
        public void CoefficientY_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = 2;
            function.CoefficientY = expected;

            // Act
            var actual = function.CoefficientY;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коллекции значений коэффициента c
        [Test(Description = "Позитивный тест сеттера коллекции коэффициента c")]
        public void CoefficientCRange_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = new ObservableCollection<double> { 6, 7, 8, 9, 10 };
            function.CoefficientCRange = expected;

            // Act
            var actual = function.CoefficientCRange;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коллекции коэффициента c")]
        public void CoefficientCRange_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = new ObservableCollection<double> { 6, 7, 8, 9, 10 };
            function.CoefficientCRange = expected;

            // Act
            var actual = function.CoefficientCRange;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коллекцию объектов хранящих результаты рассчётов функции f(x,y)
        [Test(Description = "Позитивный тест сеттера коллекции объектов " +
            "хранящих результаты рассчётов функции f(x,y)")]
        public void Results_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = new ObservableCollection<CalculateResults>();
            function.Results = expected;

            // Act
            var actual = function.Results;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коллекции объектов " +
            "хранящих результаты рассчётов функции f(x,y)")]
        public void Results_GetCorrectValue_ReturnsValue()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expected = new ObservableCollection<CalculateResults>();
            function.Results = expected;

            // Act
            var actual = function.Results;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты конструктора
        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
            // Setup
            var correctFunctionName = "Линейная";
            var expectedFunctionName = correctFunctionName;
            var correctCoefficientXpow = 1;
            var expectedCoefficientXpow = correctCoefficientXpow;
            var correctCoefficientYpow = 0;
            var expectedCoefficientYpow = correctCoefficientYpow;
            var correctCoefficientCRange = new ObservableCollection<double> { 6, 7, 8, 9, 10 };
            var expectedCoefficientCRange = correctCoefficientCRange;
            var correctResults = new ObservableCollection<CalculateResults>();
            var expectedResults = correctResults;
            Function function = new Function(correctFunctionName,
                    correctCoefficientCRange, correctCoefficientXpow, correctCoefficientYpow);

            // Act
            var actualFunctionName = function.FunctionName;
            var actualCoefficientXpow = function.CoefficientXpow;
            var actualCoefficientYpow = function.CoefficientYpow;
            var actualCoefficientCRange = function.CoefficientCRange;
            var actualResults = function.Results;

            // Assert
            Assert.Multiple(
                () =>
                {
                    ClassicAssert.AreEqual(expectedFunctionName, actualFunctionName);
                    ClassicAssert.AreEqual(expectedCoefficientXpow, actualCoefficientXpow);
                    ClassicAssert.AreEqual(expectedCoefficientYpow, actualCoefficientYpow);
                    ClassicAssert.AreEqual(expectedCoefficientCRange, actualCoefficientCRange);
                    ClassicAssert.AreEqual(expectedResults, actualResults);
                }
                );
        }

        // Тесты метода рассчёта значения функции f(x,y) и добавления новой
        // записи в коллекцию объектов хранящих результаты рассчётов
        [Test(Description = "Позитивный тест метода рассчёта значения функции" +
            " f(x,y) и добавления новой записи в коллекцию объектов хранящих " +
            "результаты рассчётов")]
        public void CalculationResult_Run_Complite()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expectedCalculationResult = 1 * Math.Pow(0, 1) + 1 * Math.Pow(0, 0) + 1;
            function.CalculateResult();

            // Act
            var actualResult = function.Results[0].CalculationResult;

            // Assert
            ClassicAssert.AreEqual(expectedCalculationResult, actualResult);
        }

        // Тесты метода перерасчёта значения функции f(x,y)
        [Test(Description = "Позитивный тест метода перерасчёта значения функции f(x,y)")]
        public void CalculateRow_Run_Complite()
        {
            // Setup
            Function function = new Function("Линейная",
                    new ObservableCollection<double> { 1, 2, 3, 4, 5 }, 1, 0);
            var expectedCalculationResult = 2 * Math.Pow(0, 1) + 1 * Math.Pow(0, 0) + 1;
            function.CalculateResult();
            function.CoefficientA = 2;
            function.CalculateRow(function.Results[0]);

            // Act
            var actualResult = function.Results[0].CalculationResult;

            // Assert
            ClassicAssert.AreEqual(expectedCalculationResult, actualResult);
        }
    }
}
