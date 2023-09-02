namespace Jokenpo_MAUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    public void PedraButton_Clicked(object sender, EventArgs e)
    {

        opcaoSelecionada(1);
    }

    public void PapelButton_Clicked(object sender, EventArgs e)
    {
        opcaoSelecionada(2);
    }

    public void TesouraButton_Clicked(object sender, EventArgs e)
    {
        opcaoSelecionada(3);
    }


    public void opcaoSelecionada(int opcaoUsuario)
	{
        TextResultado.Text = opcaoUsuario.ToString();
    }
}

