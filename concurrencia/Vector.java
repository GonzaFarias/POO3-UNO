package concurrencia;

import java.util.ArrayList;
import java.util.Collections;

public class Vector {

	private int i;
	public Vector(int i) {
		this.i = i;
	}
	
	public ArrayList<Integer> ordenarPosiciones() {
		ArrayList<Integer> vector = new ArrayList<>();
		for(int x = this.i; x>0 ; x--) {
			vector.add(x);
		}
		
	Collections.sort(vector);
	return vector;
	}

}
