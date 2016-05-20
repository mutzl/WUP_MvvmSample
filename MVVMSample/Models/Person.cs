namespace MVVMSample.Models
{
	using GalaSoft.MvvmLight;

	// INPC injected by Fody

	public class Person : ObservableObject
	{
		public Person()
		{
			
		}

		public Person(string firstname, string lastname)
		{
			Firstname = firstname;
			Lastname = lastname;
		}

		public string Firstname { get; set; }

		public string Lastname { get; set; }

		public string Fullname => $"{Lastname}, {Firstname}";

		public override string ToString()
		{
			return Fullname;
		}
	}
}