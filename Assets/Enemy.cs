using UnityEngine;
public interface IAtacable
{
    void Atacar(Enemy objetivo);
}

public interface IRecibirDanio
{
    void RecibirDanio(int cantidad);
}

public interface IDropeable
{
    Item DropearItem();
}
public abstract class Enemy : IAtacable, IRecibirDanio, IDropeable
{
    private string nombre;
    private int vida;
    private int ataque;
    private int defensa;

    // Propiedades públicas
    public string Nombre { get => nombre; protected set => nombre = value; }
    public int Vida { get => vida; protected set => vida = value; }
    public int Ataque { get => ataque; protected set => ataque = value; }
    public int Defensa { get => defensa; protected set => defensa = value; }

    // Constructor 1
    public Enemy(string nombre)
    {
        this.nombre = nombre;
        this.vida = 100;
        this.ataque = 10;
        this.defensa = 5;
    }

    // Constructor 2 (sobrecargado)
    public Enemy(string nombre, int vida, int ataque, int defensa)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.ataque = ataque;
        this.defensa = defensa;
    }

    // Implementaciones base de interfaces
    public virtual void Atacar(Enemy objetivo)
    {
        int danio = Mathf.Max(ataque - objetivo.defensa, 1);
        objetivo.RecibirDanio(danio);
        Debug.Log($"{nombre} ataca a {objetivo.Nombre} y causa {danio} de daño.");
    }

    public virtual void RecibirDanio(int cantidad)
    {
        vida -= cantidad;
        vida = Mathf.Max(vida, 0);
        Debug.Log($"{nombre} recibe {cantidad} de daño. Vida restante: {vida}");
    }

    public abstract Item DropearItem();
}
