package concurrencia;

public class Contador {
	Integer c;
	public Contador(){
		c =  new Integer(0);
		}
	public synchronized void esperar() throws InterruptedException{
		wait(10000);
		}
	public synchronized void notificar(){
		notifyAll();  //notifyAll
		} 
}
