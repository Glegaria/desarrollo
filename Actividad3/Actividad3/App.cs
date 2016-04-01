using System;
using Xamarin.Forms;

namespace Actividad3
{
		class ButtonDemoPage : ContentPage
					{
						Label label;
						
						public ButtonDemoPage()
						{
							Label header = new Label
							{
								Text = "Button",
								Font = Font.BoldSystemFontOfSize(50),
								HorizontalOptions = LayoutOptions.Center
							};

							Button button = new Button
							{
								Text = "Presiona aqui!",
								Font = Font.SystemFontOfSize(NamedSize.Large),
								BorderWidth = 1,
								HorizontalOptions = LayoutOptions.Center,
								VerticalOptions = LayoutOptions.CenterAndExpand
							};
							button.Clicked += OnButtonClicked;

							label = new Label
							{
								Text = "Usuario",
								Font = Font.SystemFontOfSize(NamedSize.Large),
								HorizontalOptions = LayoutOptions.Center,
								VerticalOptions = LayoutOptions.CenterAndExpand
							};

							// Accomodate iPhone status bar.
							this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

							// Build the page.
							this.Content = new StackLayout
							{
								Children = 
								{
									header,
									button,
									label
								}
								};
						}

						void OnButtonClicked(object sender, EventArgs e)
						{
							label.Text = "JOSE GENARO LEGARIA MONSALVO";
							//String.Format("{0} button click{1}",
							//clickTotal, clickTotal == 1 ?  "" : "s");
						}
					}  
}