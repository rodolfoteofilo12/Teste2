package com.rodolfo.estruturas.vetor;

public class Vetor {

	private String[] elementos;
	private int tamanho;

	public Vetor(int capacidade) {
		this.elementos = new String[capacidade];
		this.tamanho = 0;
	}

	// public void adiciona(String elemento) {
	// for (int i = 0; i < elementos.length; i++) {
	// if (elementos[i] == null) {
	// elementos[i] = elemento;
	// break;
	// }
	// }
	// }

	public boolean adiciona(String elemento) {

		// if (this.tamanho < this.elementos.length) {
		// this.elementos[this.tamanho] = elemento;
		// this.tamanho++;
		// }else{
		// throw new Exception("Vetor j� est� cheio, n�o e poss�vel adicionar
		// mais elementos");
		// }

		this.aumentaCapacidade();

		if (this.tamanho < this.elementos.length) {
			elementos[tamanho] = elemento;
			tamanho++;
			return true;
		}
		return false;
	}

	public int tamanho() {
		return this.tamanho;
	}

	@Override
	public String toString() {

		StringBuilder s = new StringBuilder();
		s.append("[");

		for (int i = 0; i < this.tamanho - 1; i++) {
			s.append(this.elementos[i]);
			s.append(", ");
		}

		if (this.tamanho > 0) {
			s.append(this.elementos[this.tamanho - 1]);
		}

		s.append("]");

		return s.toString();
	}

	public String busca(int posicao) {

		if (!(posicao >= 0 && posicao < tamanho)) {
			throw new IllegalArgumentException("Posi��o Inv�lida");
		}
		return this.elementos[posicao];
	}

	public int busca(String elemento) {
		for (int i = 0; i < this.tamanho; i++) {
			if (this.elementos[i].equals(elemento)) {
				return i;
			}
		}
		return -1;
	}

	public boolean adiciona(int posicao, String elemento) {

		if (!(posicao >= 0 && posicao < tamanho)) {
			throw new IllegalArgumentException("Posi��o Inv�lida");
		}

		this.aumentaCapacidade();

		// mover todos os elementos
		for (int i = tamanho - 1; i >= posicao; i--) {
			this.elementos[i] = elemento;
		}
		tamanho++;
		return true;
	}

	private void aumentaCapacidade() {
		if (this.tamanho == this.elementos.length) {
			String[] elementosNovos = new String[this.elementos.length * 2];
			for (int i = 0; i < elementos.length; i++) {
				elementosNovos[i] = elementos[i];
			}
			this.elementos = elementosNovos;
		}
	}

	public void remove(int posicao) {
		if (!(posicao >= 0 && posicao < tamanho)) {
			throw new IllegalArgumentException("Posi��o Inv�lida");
		}
		for (int i = posicao; i < this.tamanho - 1; i++) {
			this.elementos[i] = this.elementos[i - 1];
		}
		this.tamanho--;
	}

}
