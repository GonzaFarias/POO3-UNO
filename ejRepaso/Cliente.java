package ejRepaso;

import java.util.ArrayList;

public class Cliente extends PersonaJuridica {

	private int CUIT;
	private String razonSocial;
	private ArrayList<Integer> telefonos;
	private ArrayList<String> mails;
	
	public Cliente(int CUIT, String razonSocial, ArrayList<Integer> telefonos, ArrayList<String> mails) {
		super(CUIT, razonSocial, telefonos, mails);
		this.CUIT = CUIT;
		this.mails= mails;
		this.razonSocial = razonSocial;
		this.telefonos = telefonos;
	}

	public void datosContacto() {
		
	}
	
	public void historialCompras() {
		
	}
}
