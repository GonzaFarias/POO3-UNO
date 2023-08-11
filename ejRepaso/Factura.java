package ejRepaso;

import java.util.ArrayList;

public class Factura {

	private int nroFactura;
	private Cliente datosCliente;
	private ArrayList<Producto> datosProducto;
	
	public Factura(int nroFactura, Cliente datosCliente, ArrayList<Producto> datosProducto) {
		this.datosCliente = datosCliente;
		this.datosProducto = datosProducto;
		this.nroFactura = nroFactura;
	}
	
	public String datosCliente() {
		return null;
	}
	public String datosProducto() {
		return null;
	}
	
	
}
