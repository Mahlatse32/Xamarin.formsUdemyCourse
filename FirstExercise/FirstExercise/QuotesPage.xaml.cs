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
            label.Text = QuotesData(0);
		}

        int count = 0;
        public static string QuotesData(int x)
        {
            List<ButtonClickedArgs> quoteData = new List<ButtonClickedArgs>();

            quoteData.Add(new ButtonClickedArgs { quotes = "The past can’t hurt you anymore, not unless you let it" });
            quoteData.Add(new ButtonClickedArgs { quotes = "Fortune favours the brave" });
            quoteData.Add(new ButtonClickedArgs { quotes = "Did you ever stop to think, and forget to start again?" });
            quoteData.Add(new ButtonClickedArgs { quotes = "I’m not bad. I’m just drawn that way." });
            quoteData.Add(new ButtonClickedArgs { quotes = "I gave her my heart and she gave me a pen" });
            quoteData.Add(new ButtonClickedArgs { quotes = "Lies are directed to whosoever is disliked" });
            quoteData.Add(new ButtonClickedArgs { quotes = "Boredom happens only when you have so much time available" });
            quoteData.Add(new ButtonClickedArgs { quotes = "love is like taking one step backwards and taking two steps up." });
            quoteData.Add(new ButtonClickedArgs { quotes = "Be happy for this moment. This moment is your life" });
            quoteData.Add(new ButtonClickedArgs { quotes = "We loved with a love that was more than love" });
            quoteData.Add(new ButtonClickedArgs { quotes = "To find the person you can truly trust, look no further that the nearest mirror" });
            quoteData.Add(new ButtonClickedArgs { quotes = "Better to understand little than to misunderstand a lot" });
            quoteData.Add(new ButtonClickedArgs { quotes = "I write what I like" });

            return quoteData[x].quotes;
        }

        private void Button_Clicked(object sender, ButtonClickedArgs e)
        {
            if(count == 12)
            {
                count = -1;
            }
            count++;
            label.Text = QuotesData(count);
        }
    }
}