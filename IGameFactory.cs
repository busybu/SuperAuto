public interface IGameFactory
{
    Jogador CriaJogador();
    PecaArgs CriaPecaArgs();
    JogadorArgs CriaJogadorArgs();
    BatalhaArgs CriaBatalhaArgs();
    MercadoArgs CriaMercadoArgs();
    ArgsInicial CriaArgsInicial();
}