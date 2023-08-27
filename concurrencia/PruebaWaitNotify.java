package concurrencia;

public class PruebaWaitNotify implements Runnable{
	private Integer id, que;
	private  Contador c= new Contador();

public PruebaWaitNotify(int id, int que, Contador c) {
	this.id=id; this.que=que; this.c=c;}

@Override 
public void run() {   
	  System.out.println("comienza hilo (" + id.toString() + ")");
	  if(que==1)
	  	{ try {
			Thread.sleep(3000);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		  System.out.println("empiezo wait(" + id.toString() + ")");
		  try {
			c.esperar();
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		  System.out.println("salgo wait(" + id.toString() + ")");}
	  else
	  	{ try {
			Thread.sleep(4000);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		  System.out.println("disparo notify(" + id.toString() + ")");
		  c.notificar();
		  System.out.println("fin disparo notify(" + id.toString() + ")");}
	  System.out.println("fin run(" + id.toString() + ")");
}

public static void main(String[] args) {
		Contador c1= new Contador();
		PruebaWaitNotify p1=new PruebaWaitNotify(1, 1, c1);
		Thread t1=new Thread(p1);
		Thread t2=new Thread(new PruebaWaitNotify(2, 1, c1));
		Thread t3=new Thread(new PruebaWaitNotify(3, 1, c1));
		Thread t4=new Thread(new PruebaWaitNotify(4, 2, c1));
		Thread t5=new Thread(new PruebaWaitNotify(5, 2, c1));
		t1.start();
		t2.start();
		t3.start();
		t4.start();
		t5.start();
	
}
}