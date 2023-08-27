package concurrencia;

public class Buffer {
	 private int tamanio = 0;
	 private double[] buffer = null;
	 private int poner = 0, sacar = 0;
	 private int cantidad = 0;

	 public Buffer(int tamanio) {
	 this.tamanio = tamanio;
	 buffer = new double[tamanio];}
	 
	 
	 public synchronized void insertar (double valor){
		 while (cantidad == tamanio) //condición de buffer
			  try {  
				  System.out.println("Profesor corrigiendo otro parcial");
				  wait(); 
			  }
			  catch (InterruptedException e) {
				  System.err.println("wait interrumpido"); 
			  }
			  buffer[poner] = valor;
			  poner = (poner + 1) % tamanio;
			  cantidad++;
			  if(cantidad == 1) // s estaba vacio
				notify(); //inserción OK
	 }
	 
	 public synchronized double extraer() {
		 double valor;
		 while (cantidad == 0) //condición de buffer vacío
		 try {  System.out.println("Ningún parcial para corregir");
		 wait(); } 
		catch (InterruptedException e) {
		 System.err.println("wait interrumpido"); }
		 valor = buffer[sacar];
		 sacar = (sacar + 1) % tamanio;
		 cantidad--;
		 if(cantidad == tamanio-1) // si estaba lleno 		 			
			 notify();
		 return valor; //extracción OK
	 }

	 public static void main(String[] args) {
			Buffer monitor = new Buffer (1);

			new Thread(new Alumno(monitor)).start();
			new Thread(new Alumno(monitor)).start();
			new Thread(new Alumno(monitor)).start();
			new Thread(new Profesor(monitor)).start();
			new Thread(new Profesor(monitor)).start();
	}
}


