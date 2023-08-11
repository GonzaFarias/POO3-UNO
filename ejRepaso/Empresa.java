package ejRepaso;

import java.util.ArrayList;

public class Empresa {

	private int codEmpresa; 
	private String nombreEmpresa;
	private ArrayList<Sucursal> sucursales;
	private ArrayList<Cliente> clientes;
	private ArrayList<Proveedor> proveedores;

	
	public Empresa(int codEmpresa, String nombreEmpresa, ArrayList<Sucursal> sucursales) {
		this.codEmpresa = codEmpresa;
		this.nombreEmpresa = nombreEmpresa;
		this.sucursales = sucursales;
	}
	
	public void agregarSucursal(Sucursal sucursal) {
		
	}
	
	public void eliminarrSucursal(Sucursal sucursal) {
		
	}
	
	public void agregarCliente(Cliente cliente) {
		
	}
	
	public void agregarProveedor(Proveedor proveedor) {
		
	}
	
	public Factura emitirFactura(Factura factura) {
		return null;
	}
}
