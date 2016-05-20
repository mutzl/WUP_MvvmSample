namespace MVVMSample.ViewModels
{
	using GalaSoft.MvvmLight.Ioc;

	public class ViewModelLocator
	{
		static ViewModelLocator()
		{
			SimpleIoc.Default.Register<MainViewModel>();
		}

		public MainViewModel MainViewModel => new MainViewModel();
		//public MainViewModel MainViewModel => SimpleIoc.Default.GetInstance<MainViewModel>();


	}
}
