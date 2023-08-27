package concurrencia;

import java.net.*;
import java.io.*;

public class ServidorEscucha implements Runnable {
	Socket elCliente;
	DataOutputStream salida;
	BufferedReader entrada;
	String leido;

	public ServidorEscucha(Socket cliente) {
		this.elCliente = cliente;
	}

	public void run() {
		System.out.println("\n Entro puerto= " + elCliente.getPort() + "ip= " + elCliente.getRemoteSocketAddress());
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

	public static void main(String[] args) throws IOException {
		int PUERTO = 60001;
		System.out.print("\n Arranca Servidor");
		try (ServerSocket socketServidor = new ServerSocket(PUERTO)) {
			while (true) {
				Socket cliente = null;
				cliente = socketServidor.accept();
				ServidorEscucha nuevoCliente = new ServidorEscucha(cliente);
				Thread hilo = new Thread(nuevoCliente);
				hilo.start(); 
				//socketServidor.close();
			}
			
		}
	}
}
