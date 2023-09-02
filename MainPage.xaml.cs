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

    public int opcaoComputador()
    {
        Random random = new Random();
        int computadorOpcao = random.Next(1, 4);

        if (computadorOpcao == 1) ImagemOpcaoUsuario.Source = "pedra.png"; 
        else if (computadorOpcao == 2) ImagemOpcaoUsuario.Source = "papel.png"; 
        else ImagemOpcaoUsuario.Source = "tesoura.png";        

        return computadorOpcao;
    }


    public void opcaoSelecionada(int opcaoUsuario)
    {
        var usuario = opcaoUsuario;
        var computador = opcaoComputador();

        if (computador == usuario)
        {
            TextResultado.Text = "Empate!";
        }
        else if (   computador == 1 && usuario == 3 ||
                    computador == 2 && usuario == 1 ||
                    computador == 3 && usuario == 2 )
        {
            TextResultado.Text = "Você perdeu a rodada!";
        }
        else
        {
            TextResultado.Text = "Você venceu a rodada!";
        }
    }
}

/*
1 = Pedra
2 = Papel
3 = Tesoura

1 1 = empate
1 2 = usuario ganha
1 3 = computador ganha
2 2 = empate
2 1 = computador ganha
2 3 = usuario ganha
3 3 = empate
3 1 = usuario ganha
3 2 = computador ganha
 */

