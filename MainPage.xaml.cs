using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public ObservableCollection<Person> people { get; set; }
	public Person person { get; set; }
	public Person person1 { get; set; }
	public Person person2 { get; set; }
	public Person person3 { get; set; }

	public MainPage()
    {

		person = new Person("Гегель", "Пауль", "Викторович");
		person1 = new Person("Васькин", "Илья", "Владимирович");
		person2 = new Person("Арьсентьев", "Павел", "Валерьяныч");
		person3 = new Person("Рагимов", "Амир", "Онар Оглы");

		people = new ObservableCollection<Person>();
		people.Add(person);
		people.Add(person1);
		people.Add(person2);
		people.Add(person3);

		BindingContext = this;
        InitializeComponent();
    }


    private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
	{
        SearchBar s = sender as SearchBar;
        var g = (s.Parent as VerticalStackLayout).Children;
        for (int i = 0; i < people.Count; i++)
        {
            //if (e.NewTextValue != "")
            //{
            //    if (people[i].Name.Contains(e.NewTextValue))
            //    {
            //        (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
            //        continue;
            //    }

            //    else if (people[i].Surname.Contains(e.NewTextValue))
            //    {
            //        (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
            //        continue;
            //    }

            //    else if (people[i].Patronymic.Contains(e.NewTextValue))
            //    {
            //        (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
            //        continue;
            //    }
            //    else
            //    {
            //        (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
            //    }

            //}
            //else
            //{
            //    (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
            //}

                if(people[i].Name.Contains(e.NewTextValue) || people[i].Surname.Contains(e.NewTextValue) || people[i].Patronymic.Contains(e.NewTextValue)) (g[i + 1] as Grid).BackgroundColor = Color.Parse("Green");
                else (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
                if (e.NewTextValue == "") (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
        }
    }

	private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
	{
		SearchBar s = sender as SearchBar;
		var g = (s.Parent as VerticalStackLayout).Children;
        for (int i = 0; i < people.Count; i++)
        {

   //         if (people[i].Name.Contains(s.Text))
   //         {
			//	(g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
   //         }

   //         else if(people[i].Surname.Contains(s.Text))
   //         {
   //             (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
   //         }

   //         else if (people[i].Patronymic.Contains(s.Text))
   //         {
   //             (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
   //         }

   //         else
			//{
   //             (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
   //         }

            if (people[i].Name.Contains(s.Text) || people[i].Surname.Contains(s.Text) || people[i].Patronymic.Contains(s.Text)) (g[i + 1] as Grid).BackgroundColor = Color.Parse("Orange");
            else (g[i + 1] as Grid).BackgroundColor = Color.Parse("White");
            if(s.Text == "") (g[i + 1] as Grid).BackgroundColor = Color.Parse("White"); 
        }
    }

	//public void SwipeView_swipeStarted(object sender, SwipeStartedEventArgs e) 
	//{ 

	//}

	//   public void SwipeView_swipeChanging(object sender, SwipeChangingEventArgs e)
	//   {

	//   }

	//   public void SwipeView_swipeEnded(object sender, SwipeEndedEventArgs e)
	//   {

	//   }

	//private void SwipeItem_Invoked(object sender, EventArgs e)
	//{

	//}

}

