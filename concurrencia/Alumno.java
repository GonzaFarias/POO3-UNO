package concurrencia;

public class Alumno implements Runnable {
	private Buffer buf = null;
	 public Alumno (Buffer buf) {
		 this.buf = buf;
	 }
	 public void run(){
	 double item = 0.0;
	 while (true) {  
		try {
			Thread.sleep(500);
			 this.buf.insertar (item++);
			 System.out.println("Alumno entregó parcial");
		} catch (InterruptedException e) {
			e.printStackTrace();
		}}  

	 }
	 public static void main(String[] args) {
		System.out.println(8%9);
	}
}
