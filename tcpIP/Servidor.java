package tcpIP;

import java.io.*;
import java.net.*;

public class Servidor implements Runnable {
	Socket elCliente;
	DataOutputStream salida;
	BufferedReader entrada;
	String leido;

	Servidor(Socket cliente) {
		elCliente = cliente;
	}

	public void run() {
		System.out.println("\n Entro puerto = " + elCliente.getPort() + " ip = " + elCliente.getRemoteSocketAddress());
		try {
			salida = new DataOutputStream(elCliente.getOutputStream());
			salida.writeBytes("\nHola\n");
			Thread.sleep(5000);
			while (true) {
				entrada = new BufferedReader(new InputStreamReader(elCliente.getInputStream()));
				System.out.print("\nEsperando");
				leido = entrada.readLine();
				System.out.print("\nLeido" + leido + "\n");
				salida.writeBytes("\nLeido" + leido + "\n");
			}
		} catch (Exception e) {
			System.out.println(e.getMessage());
		}
	}

	public static void main(String [ ] args) throws IOException{
	int PUERTO=60001; 
	System.out.print("\n Arranca Servidor");
	try (ServerSocket socketServidor = new ServerSocket(PUERTO)) {
		while (true){
			Socket cliente=null;
			cliente = socketServidor.accept();
			Servidor nuevoCliente=new Servidor( cliente);
			Thread hilo = new Thread(nuevoCliente); 
			hilo.start();
		}
	}
	catch(Exception e) {
		e.getMessage();
	}
	}
	
}
