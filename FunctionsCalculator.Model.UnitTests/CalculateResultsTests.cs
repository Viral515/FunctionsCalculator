using GalaSoft.MvvmLight.CommandWpf;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace FunctionsCalculator.Model.UnitTests
{
    [TestFixture]
    public class CalculateResultsTests
    {
        // Тесты коэффициента x
        [Test(Description = "Позитивный тест сеттера коэффициента x")]
        public void CoefficientX_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            CalculateResults result = new CalculateResults(1,1,1,
                new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CoefficientX = expected;

            // Act
            var actual = result.CoefficientX;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента x")]
        public void CoefficientX_GetCorrectValue_ReturnsValue()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1,
                new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CoefficientX = expected;

            // Act
            var actual = result.CoefficientX;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты коэффициента y
        [Test(Description = "Позитивный тест сеттера коэффициента y")]
        public void CoefficientY_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1,
                new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CoefficientY = expected;

            // Act
            var actual = result.CoefficientY;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера коэффициента y")]
        public void CoefficientY_GetCorrectValue_ReturnsValue()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1,
                new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CoefficientY = expected;

            // Act
            var actual = result.CoefficientY;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты результата рассчёта функции f(x,y)
        [Test(Description = "Позитивный тест сеттера результата рассчёта функции f(x,y)")]
        public void CalculationResult_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1,
                new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CalculationResult = expected;

            // Act
            var actual = result.CalculationResult;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера результата рассчёта функции f(x,y)")]
        public void CalculationResult_GetCorrectValue_ReturnsValue()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1, new RelayCommand<CalculateResults>(Command));
            var expected = 2;
            result.CalculationResult = expected;

            // Act
            var actual = result.CalculationResult;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты команды для рассчёта функции
        [Test(Description = "Позитивный тест сеттера команды для рассчёта функции")]
        public void CalculateCommand_SetCorrectValue_ValueIsSetted()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1,
                new RelayCommand<CalculateResults>(Command));
            var expected = new RelayCommand<CalculateResults>(Command);
            result.CalculateCommand = expected;

            // Act
            var actual = result.CalculateCommand;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера команды для рассчёта функции")]
        public void CalculateCommand_GetCorrectValue_ReturnsValue()
        {
            // Setup
            CalculateResults result = new CalculateResults(1, 1, 1, new RelayCommand<CalculateResults>(Command));
            var expected = new RelayCommand<CalculateResults>(Command);
            result.CalculateCommand = expected;

            // Act
            var actual = result.CalculateCommand;

            // Assert
            ClassicAssert.AreEqual(expected, actual);
        }

        // Тесты конструктора
        [Test(Description = "Позитивный тест конструктора с параметрами")]
        public void Constructor_SetCorrectParameters_ReturnsCorrectValues()
        {
            // Setup
            var correctCoefficientX = 2;
            var expectedCoefficientX = correctCoefficientX;
            var correctCoefficientY = 2;
            var expectedCoefficientY = correctCoefficientY;
            var correctCalculateResult = 2;
            var expectedCalculateResult = correctCalculateResult;
            var correctCommand = new RelayCommand<CalculateResults>(Command);
            var expectedCommand = correctCommand;
            CalculateResults result = new CalculateResults(correctCoefficientX,
                correctCoefficientY, correctCalculateResult, correctCommand);

            // Act
            var actualCoefficientX = result.CoefficientX;
            var actualCoefficientY = result.CoefficientY;
            var actualCalculateResult = result.CalculationResult;
            var actualCommand = result.CalculateCommand;

            // Assert
            Assert.Multiple(
                () =>
                {
                    ClassicAssert.AreEqual(expectedCoefficientX, actualCoefficientX);
                    ClassicAssert.AreEqual(expectedCoefficientY, actualCoefficientY);
                    ClassicAssert.AreEqual(expectedCalculateResult, actualCalculateResult);
                    ClassicAssert.AreEqual(expectedCommand, actualCommand);
                }
                );
        }

        /// <summary>
        /// Заглушка для конструктора CalculateResults
        /// </summary>
        /// <param name="calculate"></param>
        public void Command(CalculateResults calculate)
        {

        }
    }
}
