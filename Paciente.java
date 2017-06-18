package com.rodolfo.estruturas.fila.teste;

public class Paciente {

	private String nome;
	private int prioridade;

	public Paciente(String nome, int prioridade) {
		super();
		this.nome = nome;
		this.prioridade = prioridade;
	}

	public Paciente() {

	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public int getPrioridade() {
		return prioridade;
	}

	public void setPrioridade(int prioridade) {
		this.prioridade = prioridade;
	}

	@Override
	public String toString() {
		return "Paciente [nome=" + nome + ", prioridade=" + prioridade + "]";
	}
	
	
}
