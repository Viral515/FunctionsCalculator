using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace FunctionsCalculator.View
{
    /// <summary>
    /// Класс реализующий пользовательский TextBox для ввода чисел
    /// </summary>
    public class DigitalTextBox : TextBox
    {
        /// <summary>
        /// Список разрешенных для ввода символов
        /// </summary>
        private static readonly Regex regex = new Regex("^[0-9-]");

        /// <summary>
        /// Проверка ввода спец символов и удаления текста
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            if ((this.Text.Length == 1 && e.Key == Key.Back) 
                || (this.SelectionLength == this.Text.Length && e.Key == Key.Back) 
                || ((this.Text.Count(c => c == '-') > 0) && e.Key == Key.OemMinus)
                || (this.Text.Length == 2 && this.Text.Count(c => c == '-') > 0 
                && e.Key == Key.Back && this.SelectionStart == 2))
            {
                e.Handled = true;
            }
            
            base.OnPreviewKeyDown(e);
        }

        /// <summary>
        /// Проверка ввода символов
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            if (!regex.IsMatch(e.Text))
                e.Handled = true;
            base.OnPreviewTextInput(e);
        }
    }
}
