package concurrencia;

import java.util.ArrayList;

public class miHilo implements Runnable{
	private Integer id;
	private ArrayList<Vector> vector;
	private Sincronizar s;
public miHilo(ArrayList<Vector> vector, Integer id, Sincronizar s){
	this.vector=vector;
	this.id = id;
	this.s = s;
	}
public void run() { 
	long tiempoInicio;
	long tiempoFinal;
	tiempoInicio = System.nanoTime();
	System.out.println("comienza hilo (" + id.toString() + ")");
	for(Vector x : vector) {
		ArrayList<Integer> lista = x.ordenarPosiciones();
		System.out.println(lista.toString());

	}
	System.out.print("Sincronizador tira: ");
	try {
		s.imprimirId(id);
	} catch (InterruptedException e) {
		e.printStackTrace();
	}
	tiempoFinal = System.nanoTime();
	System.out.println("Tiempo: "+ (tiempoFinal - tiempoInicio) + " ns");
}

public static void main(String[] args) throws InterruptedException {
	
	ArrayList<Vector> vector = new ArrayList<Vector>();
	
	for(int x = 0; x<200; x++) {
		if(x % 2 == 0) {
			vector.add(new Vector(500));
		}
		else {
			vector.add(new Vector(500));
		}
		
	}
	
	Sincronizar s = new Sincronizar();
	miHilo uno = new miHilo (vector, 1, s);
	miHilo dos = new miHilo (vector, 2, s); 
	miHilo tres = new miHilo (vector, 3, s); 
	miHilo cuatro = new miHilo (vector, 3, s); 
	Thread tresHilo = new Thread(tres);
	Thread unHilo = new Thread(uno);
	Thread dosHilo = new Thread(dos);
	Thread cuatroHilo = new Thread(cuatro);

	dosHilo.start();
	unHilo.start();
	tresHilo.start();
	cuatroHilo.start();
	tresHilo.join();
    unHilo.join();
    dosHilo.join();
	cuatroHilo.join();



	System.out.println("de running a terminated");
	
	
}
}
