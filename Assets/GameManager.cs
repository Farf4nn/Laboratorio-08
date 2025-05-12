using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    Player jugador;
    Enemy enemigo;
    public interface IAtacable
    {
        void Atacar(Enemy objetivo);
    }

    public interface IRecibirDanio
    {
        void RecibirDanio(int cantidad);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        {
            Orco orco = new Orco("Grumoso", 150, 20, 10);
            Esqueleto esqueleto = new Esqueleto("Bonedoggle", 80, 15, 5);

            orco.Atacar(esqueleto);
            esqueleto.LanzarHueso(orco);

            Item itemDroppOrco = orco.DropearItem();
            itemDroppOrco.Usar();

            Item itemDropEsqueleto = esqueleto.DropearItem();
            itemDropEsqueleto.Usar();
        }
        jugador = new Player(vida: 100, daño: 25, durabilidad: 6);
        enemigo = new Orco("Orco Guerrero", 80, 15);

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            try
            {
                jugador.Atacar(enemigo);
                ((Orco)enemigo).AtacarJugador(jugador);
            }
            catch (Exception ex)
            {
                Debug.LogError("Error: " + ex.Message);
            }
        }
    }
}
