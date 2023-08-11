package ejRepaso;

import java.util.ArrayList;

public class Sucursal {

	private String nombre;
	private String direccion;
	private ArrayList<Empleado> empleados;
	private ArrayList<Producto> productos;
	
	public Sucursal(String nombre, String direccion, ArrayList<Empleado> empleados) {
		this.direccion = direccion;
		this.nombre= nombre;
		this.empleados = empleados;
	}
	
	public void agregarEmpleado(Empleado empleado) {
		
	}
	
	public void eliminarEmpleado(Empleado empleado) {
		
	}
	
	public String getListaProductos() {
		return "";
	}
	
	public void editarStockProducto(Producto producto, int stock) {
		
	}
}
