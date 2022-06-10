using System;

class Conta
{
	public int numero;
	public string titular;
	public double saldo;

	public void Deposita(double valor)
    {
		saldo += valor;
    }
	public void Saca(double valorSaque)
    {
		saldo -= valorSaque;
    }
}
