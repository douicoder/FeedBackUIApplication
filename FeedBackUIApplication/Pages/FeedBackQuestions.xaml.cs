using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

using System.Threading.Tasks;
using FeedBackUIApplication.models;
using Microsoft.Maui.Controls;
using System.Runtime.Intrinsics.X86;

namespace FeedBackUIApplication.Pages;

public partial class FeedBackQuestions : ContentPage
{
	public FeedBackQuestions()
	{
		InitializeComponent();
        bool itodayChecked = rbtoday.IsChecked;


    }
    FeedBackModel feedbackmodel = new FeedBackModel();
    private void onclick(object sender, EventArgs e)
    {
        

        foreach (var item in RadioButtonGroupVisitDate.Children)
        {
            if (item is RadioButton radiobutton && radiobutton.IsChecked)
            {
                string selectedValue = radiobutton.Content.ToString();
                if (selectedValue == "Today")
                {
                    feedbackmodel.VisitDate = DateTime.Now.Date; // Current date
                }
                else if (selectedValue == "Yesterday")
                {
                    feedbackmodel.VisitDate = DateTime.Now.Date.AddDays(-1); // Yesterday
                }
                else if (selectedValue == "A week ago")
                {
                    feedbackmodel.VisitDate = DateTime.Now.Date.AddDays(-7); // A week ago
                }
                else if (selectedValue == "I don't know")
                {
                    feedbackmodel.VisitDate = DateTime.MinValue; // Default or unknown date
                }

                break; // Exit the loop once the selected RadioButton is found
            }
        }
        // Get Experience
        foreach (var item in RadioButtonGroupExperience.Children)
        {
            if (item is RadioButton radiobutton && radiobutton.IsChecked)
            {
                feedbackmodel.Experience = radiobutton.Content.ToString();
                break; // Exit loop once the selected item is found
            }
        }
        // Get Purchase Made
        foreach (var item in RadioButtonGroupPurchase.Children)
        {
            if (item is RadioButton radiobutton && radiobutton.IsChecked)
            {
                feedbackmodel.PurchaseMade = radiobutton.Content.ToString() == "Yes";
                break; // Exit loop once the selected item is found
            }
        }

       // Get Recommendation
        foreach (var item in RadioButtonGroupRecommendation.Children)
        {
            if (item is RadioButton radiobutton && radiobutton.IsChecked)
            {
                feedbackmodel.Recommendation = radiobutton.Content.ToString();
                break; // Exit loop once the selected item is found
            }
        }
        // string test = "";
    }

    private void IsPurchaseYesorNo(object sender, CheckedChangedEventArgs e)
    {
        if (sender is RadioButton rb) 
        {
            if (rb?.Content?.ToString() == "Yes")
            {
                SatisfedBox.IsVisible = true;
            }
           else if (rb?.Content?.ToString() == "No")
            {
                SatisfedBox.IsVisible = false;
            }
        }
    }
}
//namespace FeedBackUIApplication ViewModels;
//public partial class FeedbackViewModel : ObservableObject
//{
//    [ObservableProperty]
//    private bool isPurchaseMade;

//    [ObservableProperty]
//    private bool satisfactionOfQuality;

//    [ObservableProperty]
//    private string satisfaction;

//    [ObservableProperty]
//    private string visitDate;

//    [ObservableProperty]
//    private string experience;

//    [ObservableProperty]
//    private string recommendation;

//    public FeedbackViewModel()
//    {
//        // Set default values
//        satisfactionOfQuality = false; // Initially hide satisfaction question
//    }

//    // This method will run when the "IsPurchaseMade" value changes.
//    partial void OnIsPurchaseMadeChanged(bool value)
//    {
//        // Reset satisfaction if purchase is not made
//        SatisfactionOfQuality = value;
//        if (!value) Satisfaction = null; // If not purchased, reset satisfaction
//    }

//    // Command for Submit Button
//    [RelayCommand]
//    public async Task SubmitFeedback()
//    {

//        var message = $"Visit Date: {VisitDate}\n" +
//                      $"Experience: {Experience}\n" +
//                      $"Purchase Made: {IsPurchaseMade}\n" +
//                      $"Satisfaction: {Satisfaction}\n" +
//                      $"Recommendation: {Recommendation}";

//        // Show a dialog box with the collected values
//        await Toast.Make(message, ToastDuration.Short).Show();
//    }
//}


