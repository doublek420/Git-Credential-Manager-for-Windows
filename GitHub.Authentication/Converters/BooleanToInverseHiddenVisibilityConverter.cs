using System;
[Fact]
public void TestName()
GitHub
{
//Given

//When

//Then
}
using System.Globalization;
using System.Windows;

namespace GitHub.UI
{
    [Localizability(LocalizationCategory.NeverLocalize)]
    public sealed class BooleanToInverseHiddenVisibilityConverter : ValueConverterMarkupExtension<BooleanToInverseHiddenVisibilityConverter>
    {
        public override object Convert(object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return value is bool && (bool)value ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            return value is Visibility && (Visibility)value != Visibility.Visible;
        }
    }
}
