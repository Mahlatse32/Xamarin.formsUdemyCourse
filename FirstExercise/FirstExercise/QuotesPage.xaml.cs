using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FirstExercise
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class QuotesPage : ContentPage
	{
		public QuotesPage ()
		{
			InitializeComponent ();
            label.Text = quotes[count];
		}

        int count = 0;

        private string[] quotes = new string[]
        {
            "The past can’t hurt you anymore, not unless you let it",
            "Fortune favours the brave",
            "Did you ever stop to think, and forget to start again?",
            "I’m not bad. I’m just drawn that way.",
            "I gave her my heart and she gave me a pen",
            "Lies are directed to whosoever is disliked",
            "Boredom happens only when you have so much time available",
            "love is like taking one step backwards and taking two steps up.",
            "Be happy for this moment. This moment is your life",
            "We loved with a love that was more than love",
            "To find the person you can truly trust, look no further that the nearest mirror",
            "Better to understand little than to misunderstand a lot",
            "I write what I like"
        };

        private void Button_Clicked(object sender, ButtonClickedArgs e)
        {
            count++;

            if (count >= quotes.Length)
            {
                count = 0;
            }

            label.Text = quotes[count];
        }
    }
}