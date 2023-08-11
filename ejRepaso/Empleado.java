package ejRepaso;

import java.util.ArrayList;

public class Empleado {

	private int legajo;
	private String nombre;
	private int DNI;
	private ArrayList<Integer> telefonos;
	private ArrayList<String> mails;
	
	public Empleado(int legajo, String nombre, int DNI, ArrayList<Integer> telefono, ArrayList<String> mails) {
		this.DNI = DNI;
		this.legajo = legajo;
		this.mails = mails;
		this.telefonos = telefonos;
	}

	public String datosContacto() {
		return "";
	}
	
	public String obtenerDatos() {
		return "";
	}
}
