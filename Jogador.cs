
using System.Collections.Generic;
public abstract class Jogador
{
    public bool Vivo { get; set; }
    public int Vidas { get; set; }
    public int Moedas { get; set; }
    public int Trofeus { get; set; }
    
    // Deixa as máquinas visiveis mas evita modificações de forma errada
    private List<T> maquinas { get; set; }
    public IEnumerable<T> Maquinas => maquinas;

}
