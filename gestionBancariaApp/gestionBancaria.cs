﻿using System;
using System.Windows.Forms;

/// <summary>
/// Summary description for Class1
/// </summary>
///


public class gestionBancaria
{
    public double saldo;  // Saldo inicial de la cuenta, 1000€
    public const int ERR_OPERACION_NO_SELECCIONADA = 2;
    public const int ERR_CANTIDAD_INDICADA_NEGATIVA = 1;
    public const int ERR_SALDO_INSUFICIENTE = 3;


    public gestionBancaria(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public double obtenerSaldo()
    {
        return saldo;
    }

    // Añadido método para exámen 2ª evaluación:
    public void aperturaCuenta(double cantidadApertura)
    {
        if (cantidadApertura >= 1 && cantidadApertura <= 100)
            saldo = cantidadApertura;
        else
            saldo = 0;
    }

    public void realizarReintegro(double cantidad)
    {
        if (cantidad < 0) // código corregido
        {
            //mostrarError(ERR_CANTIDAD_INDICADA_NEGATIVA);
            throw new ArgumentOutOfRangeException("Cantidad indicada es negativa");
        }
        else
        {
            if (cantidad >= 0 && saldo >= cantidad) // código corregido
            {
                saldo -= cantidad;
            }
            else
                //mostrarError(ERR_SALDO_INSUFICIENTE);
                throw new ArgumentOutOfRangeException("Saldo insuficiente");
        } 
    }

    public void realizarIngreso(double cantidad)
    {
        if (cantidad < 0)
        {
            //mostrarError(ERR_CANTIDAD_INDICADA_NEGATIVA);
            throw new ArgumentOutOfRangeException("Cantidad indicada es negativa");
        }
        else
        {
            if (cantidad > 0)
                saldo += cantidad; // CORREGIDO
        }      
    }


    public void mostrarError(int error)
    {

        switch (error)
        {
            case ERR_CANTIDAD_INDICADA_NEGATIVA:
                MessageBox.Show("Cantidad no válidá, sólo se admiten cantidades positivas.");
                break;
            case ERR_OPERACION_NO_SELECCIONADA:
                MessageBox.Show("Seleccione la operación a realizar");
                break;
            case ERR_SALDO_INSUFICIENTE:
                MessageBox.Show("No se ha podido realizar la operación (¿Saldo insuficiente?)");
                break;

        }

    }
}