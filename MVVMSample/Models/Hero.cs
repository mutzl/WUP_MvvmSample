namespace MVVMSample.Models
{
	public class Hero : Person
	{
		public Hero()
		{

		}

		public Hero(string firstname, string lastname)
		{
			Firstname = firstname;
			Lastname = lastname;
		}

		public int Power { get; set; } = 1;

		public void IncreasePower()
		{
			Power++;
		}

	}
}

