public abstract class Peca
{
    private int Xp { get; set; }
    private int Tier { get; set; }
    private int Vida { get; set; } 
    private int Valor { get; set; }
    private int Nivel { get; set; }
    private int Ataque { get; set; }
    private string Nome { get; set; }

    public virtual void Atacar(var Peca) 
    {
        Peca.TomarDano(this.Ataque);
    }
    public virtual void TomarDano(int Dano) 
    {
        this.Vida -= Dano;
    }
}
public class FuradeiradeColuna : Peca
{
    public FuradeiradeColuna()
    {
        this.Xp = 1;
        this.Tier = 2;
        this.Ataque = 3;
        this.Vida = 5;
        this.Nome = "Furadeira de Coluna";
        this.Nivel = 1;
        this.Valor = 3;
    }
}
public class FuradeiradeCoordenada : Peca
{
    public FuradeiradeCoordenada()
    {
        this.Xp = 1;
        this.Tier = 2;
        this.Ataque = 3;
        this.Vida = 5;
        this.Nome = "Furadeira de Coordenada";
        this.Nivel = 1;
        this.Valor = 3;
    }

    public override void TomarDano(int Dano)
    {
        this.Vida -= Dano;

        if (this.Vida >= 1)
        {
            
        }
    }
}
