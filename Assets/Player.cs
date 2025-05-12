using UnityEngine;
using System;

public class Player : MonoBehaviour
{
    public int Vida { get; private set; }
    public int Da�o { get; private set; }
    public int DurabilidadArma { get; private set; }

    public Player(int vida = 100, int da�o = 20, int durabilidad = 5)
    {
        Vida = vida;
        Da�o = da�o;
        DurabilidadArma = durabilidad;
    }

    public void Atacar(Enemy enemigo)
    {
        if (DurabilidadArma <= 0)
            throw new Exception("El arma del jugador est� rota y no puede atacar.");

        int da�oAleatorio = UnityEngine.Random.Range(Da�o / 2, Da�o + 1);
        enemigo.RecibirDanio(da�oAleatorio);

        int desgaste = UnityEngine.Random.Range(1, 3);
        DurabilidadArma -= desgaste;

        Debug.Log($"Jugador ataca al enemigo causando {da�oAleatorio} de da�o. Durabilidad del arma restante: {DurabilidadArma}");
    }

    public void RecibirDanio(int cantidad)
    {
        Vida -= cantidad;
        Debug.Log($"Jugador recibe {cantidad} de da�o. Vida restante: {Vida}");

        if (Vida <= 0)
            throw new Exception("El jugador ha muerto.");
    }
}
