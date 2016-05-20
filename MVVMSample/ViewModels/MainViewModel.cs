namespace MVVMSample.ViewModels
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.ComponentModel;
	using System.Windows.Input;

	using Windows.ApplicationModel.VoiceCommands;

	using GalaSoft.MvvmLight;
	using GalaSoft.MvvmLight.Command;

	using MVVMSample.Models;

	using PropertyChanged;

	// INPC injected by Fody
	public class MainViewModel : ViewModelBase 
	{
		public MainViewModel()
		{
			Person = new Person
				         {
					         Firstname = "Thomas",
					         Lastname = "Mutzl"
				         };

			Person.PropertyChanged += (sender, args) =>
				{
					if (args.PropertyName == "Lastname") RaisePropertyChanged(nameof(IsNameToShort));
				};



			Heros = new ObservableCollection<Hero>
				        {
					        new Hero("Chuck", "Norris"),
							new Hero("James", "Bond"),
				        };

			AddHeroCommand = new RelayCommand(AddHero);


		}



		public Person Person { get; }

		public ObservableCollection<Hero> Heros { get; }

		public Hero SelectedHero { get; set; }

		public void UpgradeSelectedHero()
		{
			SelectedHero.IncreasePower();
		}

		public bool CanUpgradeSelectedHero => SelectedHero != null;

		public bool IsNameToShort => Person.Lastname.Length <= 2;

		public string NewHeroFirstname { get; set; }
		public string NewHeroLastname { get; set; }

		public void AddHero()
		{
			Heros.Add(new Hero(NewHeroFirstname, NewHeroLastname));
			NewHeroFirstname = string.Empty;
			NewHeroLastname = string.Empty;
		}

		public bool CanAddHero
		{
			get
			{
				return !string.IsNullOrEmpty(NewHeroFirstname) 
					&& !string.IsNullOrEmpty(NewHeroLastname);
			}
		}

		public RelayCommand AddHeroCommand { get; }
	}
}
