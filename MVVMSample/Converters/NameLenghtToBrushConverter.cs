using System;


namespace MVVMSample.Converters
{
	using Windows.UI;
	using Windows.UI.Xaml;
	using Windows.UI.Xaml.Data;
	using Windows.UI.Xaml.Media;

	class NameLenghtToBrushConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (!(value is bool) || targetType != typeof(Brush)) return DependencyProperty.UnsetValue;

			var color = ((bool)value) ? Colors.Red : Colors.Black;

			return new SolidColorBrush(color);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}


	class BoolToBrushConverter : IValueConverter
	{

		public Color TrueColor { get; set; } = Colors.Green;

		public Color FalseColor { get; set; } = Colors.Red;

		public object Convert(object value, Type targetType, object parameter, string language)
		{
			if (!(value is bool) || targetType != typeof(Brush)) return DependencyProperty.UnsetValue;

			var color = ((bool)value) ? TrueColor : FalseColor;

			return new SolidColorBrush(color);
		}

		public object ConvertBack(object value, Type targetType, object parameter, string language)
		{
			throw new NotImplementedException();
		}
	}

}
