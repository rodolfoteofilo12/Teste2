package com.rodolfo.estruturas.fila.teste;

import com.rodolfo.estruturas.fila.Fila;

public class Aula21 {

	public static void main(String[] args) {

		Fila<Integer> fila = new Fila<>();
		
		fila.enfileira(1);
		fila.enfileira(2);
		
		System.out.println(fila.espiar());
	}

}
