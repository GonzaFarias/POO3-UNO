package concurrencia;

public class Sincronizar {

	private int contador = 0;
	public Sincronizar() {
		
	}
	
	public synchronized void imprimirId(Integer id) throws InterruptedException{
		System.out.println("Id de hilo: "+id);
		contador++;
		System.out.println(contador);
		}

}
