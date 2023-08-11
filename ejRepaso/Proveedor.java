package ejRepaso;

import java.util.ArrayList;

public class Proveedor extends PersonaJuridica{

	private int CUIT;
	private String razonSocial;
	private ArrayList<Integer> telefonos;
	private ArrayList<String> mails;
	private ArrayList<Producto> productos;
	
	public Proveedor(int CUIT, String razonSocial, ArrayList<Integer> telefonos, ArrayList<String> mails) {
		super(CUIT, razonSocial, telefonos, mails);
		this.CUIT = CUIT;
		this.mails= mails;
		this.razonSocial = razonSocial;
		this.telefonos = telefonos;
	}

	public void datosContacto() {
		
	}
	
	public String getListaProductos () {
		return "";
	}
	
	public void agregarProductos(ArrayList<Producto> productos) {
		
	}

}
