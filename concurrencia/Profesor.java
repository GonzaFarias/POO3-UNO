package concurrencia;

class Profesor implements Runnable {
	   private Buffer buf = null;
	   public Profesor (Buffer buf) {this.buf = buf; }
	   public void run() {
	   double item;
	   while (true) {
	        item = buf.extraer();
	        try {
				Thread.sleep(500);
			} catch (InterruptedException e) {
				e.printStackTrace();
			}  // try/catch
	        System.out.println("Corrigiendo parcial numero " + item);
	        System.out.println("El alumno se sacó nota: "+(int)(Math.random()*10+1));
	       }
	   }
	}