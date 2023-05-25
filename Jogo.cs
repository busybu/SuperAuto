using System.Linq;
using System.Collections.Generic;

public class Jogo
{
    // SingleTon para permitir botão de reiniciar/resetar     
    private Jogo() { }
    private static Jogo crr = null;
    public static Jogo Current => crr;

    // Seta valores iniciais
    private int Round { get; set; } = 0;
    private int VidaInicial { get; set; }
    private int LimiteMaquinasMercado { get; set; }
    private Jogador Jogador = null;
    private Mercado Mercado = null;
    private Batalha Batalha = null;
    private PecaArgs PecaArgs = null;
    private JogadorArgs JogadorArgs = null;
    private BatalhaArgs BatalhaArgs = null;
    private MercadoArgs MercadoArgs = null;
    private SetInicial SetInicial = null;
    private ArgsInicial ArgsInicial = null;

    public void Configurar()
    {
        SetInicial.Setup(ArgsInicial);
    }

    public void Executar()
    {
        while (this.Jogador.Vivo)
        {
            this.Mercado.Executar();
            this.Batalha.Executar();
        }
    }

    // Define como vai funcionar o Builder
    public class JogoBuilder
    {
        private Jogo jogo = new Jogo();

        public Jogo Build()
            => this.jogo;

        public JogoBuilder SetVidaInicial(int vida)
        {
            jogo.VidaInicial = vida;
            return this;
        }

        public JogoBuilder SetJogador(Jogador jogador)
        {
            jogo.Jogador = jogador;
            return this;
        }

        public JogoBuilder SetBatalha(Batalha batalha)
        {
            jogo.Batalha = batalha;
            return this;
        }

        public JogoBuilder SetMercado(Mercado mercado)
        {
            jogo.Mercado = mercado;
            return this;
        }

        public JogoBuilder SetLimiteMaquinasMercado(int maquinas)
        {
            jogo.LimiteMaquinasMercado = maquinas;
            return this;
        }

        public JogoBuilder SetSetInicial(SetInicial setInicial)
        {
            jogo.SetInicial = setInicial;
            return this;
        }

        public JogoBuilder SetaFactory(IGameFactory factory)
        {
            jogo.Jogador = factory.CriaJogador();
            jogo.PecaArgs = factory.CriaPecaArgs();
            jogo.JogadorArgs = factory.CriaJogadorArgs();
            jogo.BatalhaArgs = factory.CriaBatalhaArgs();
            jogo.MercadoArgs = factory.CriaMercadoArgs();
            jogo.ArgsInicial = factory.CriaArgsInicial();
            return this;
        }
    }
    public static JogoBuilder GetBuilder()
        => new JogoBuilder();

    public static void New(JogoBuilder builder)
        => crr = builder.Build();
}

