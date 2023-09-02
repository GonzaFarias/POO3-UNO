package cliente_servidor;

import java.net.*;
import javax.swing.JOptionPane;
import java.io.*;

public class Cliente {
	public static void main(String[] args) throws UnknownHostException, IOException {
		String s = "";
		int PUERTO = 49739;
		try (Socket cliente = new Socket("localhost", PUERTO)) {
			BufferedReader entrada = new BufferedReader(new InputStreamReader(cliente.getInputStream()));
			BufferedWriter salida = new BufferedWriter(new OutputStreamWriter(cliente.getOutputStream()));

			while (true) {
				while ((s = entrada.readLine()).length() == 0) {
					System.out.println("Leido: " + s);
					String mensaje;
					mensaje = JOptionPane.showInputDialog("Mensaje");
					salida.write(mensaje + "\n");
					salida.flush();
				}
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
