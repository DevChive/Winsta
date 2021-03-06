﻿using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace WinGoTag.View.SettingsView
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class StorySettingsView : Page
    {
        public StorySettingsView() => InitializeComponent();
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.NavigationMode != NavigationMode.Back)
                AppCore.ModerateBack(Frame.GoBack);
        }

        public void Return()
        {
            Frame.GoBack();
            AppCore.ModerateBack("");
        }

        private void ToBackBT_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) => Return();

    }
}
