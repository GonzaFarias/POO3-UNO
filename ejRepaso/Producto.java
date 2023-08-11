package ejRepaso;

public class Producto {

	private int codigo;
	private String nombre;
	private TipoHardware tipo;
	private int stock;
	
	public Producto(int codigo, String nombre, TipoHardware tipo, int stock) {
		this.codigo = codigo;
		this.nombre = nombre;
		this.stock = stock;
		this.tipo = tipo;
	}
	
	public void modificarStock(int stock) {
		
	}
}
