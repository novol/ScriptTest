using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int hp = 100;
	private int power = 25;
	private int mp = 53;

	public void Attack() {
		Debug.Log (this.power + "のダメージを与えた");
	}

	public void Defence(int damage) {
		Debug.Log (damage + "のダメージを受けた");
		this.hp -= damage;
		Debug.Log ("残りHP:" + hp);
	}

	public void Magic() {
		
		Debug.Log ("mp:" + mp);

		if (mp < 5) {
			Debug.Log ("MPが足りないため魔法が使えない。");
		} else {
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp +"。");
		}
	}

}

public class Test : MonoBehaviour {

	void Hello(){
		Debug.Log ("Hello");
	}

	void HelloName(string name){
		Debug.Log ("Hello," + name);
	}

	int Add(int a, int b){
		int c = a + b;
		return c;
	}

	// Use this for initialization
	void Start () {

		/*
		 * ---------------
		 * 課題
		 * ---------------
		 */
		int[] array = { 1, 10, 300, 5, 60 };

		for (int i = 0; i < array.Length; i++) {
			Debug.Log ("i[" + i +"] " + array [i]);
		}

		for (int j = array.Length; j > 0; j--) {
			Debug.Log ("j[" +(j - 1) + "] " + array [j - 1]);
		}

		Boss KadaiBoss = new Boss();
		for (int i = 0; i <= 12; i++) {
			Debug.Log ((i+1) + "回目");
			KadaiBoss.Magic ();
		}

		Debug.Log ("ループ外");
		KadaiBoss.Magic ();

/*
 * ------------
 * 練習
 * ------------
 */

//		Debug.Log ("Hello, World");

//		int score;
//		score = 150;
//		Debug.Log (score);

//		int a = 3;
//		int b = 4;
//		int c = a + b;
//		Debug.Log (c);

//		int money = 200;
//		int money = 50;
//
//		if (money >= 100) {
//			Debug.Log ("ポーションを買う");
//		}

//		int money = 100;
//
//		if (money <= 50) {
//			Debug.Log ("武器を売る");
//		} else if (money >= 200) {
//			Debug.Log ("武器を買う");
//		} else {
//			Debug.Log ("ポーションを買う");
//		}

//		int num = 1;
//		int val = (num == 1) ? -100 : 100;
//		Debug.Log (val);

//		int val;
//		int num = 1;
//		if (num == 1) {
//			val = -100;
//		} else {
//			val = 100;
//		}
//		Debug.Log (val);

//		for (int i = 0; i < 5; i++) {
//			Debug.Log (i);
//		}

//		int[] points = new int[5];
//
//		points [0] = 30;
//		points [1] = 20;
//		points [2] = 50;
//		points [3] = 10;
//		points [4] = 80;
//		for (int i = 0; i < 5; i++) {
//			Debug.Log (points [i]);
//		}
//
//		int[] points= {30,20,50,10,80,15,60,100};
//
//		for (int i = 0; i < points.Length; i++) {
//			Debug.Log (points [i]);
//		}
	
//		Hello ();

//		HelloName ("Unity");

//		int num = Add (3, 6);
//		Debug.Log (num);

//		Boss lastboss = new Boss ();
//		Boss midboss = new Boss ();
//
//		lastboss.Attack ();
//		lastboss.Defence (3);
//	
//		midboss.Attack ();
//		midboss.Defence (10);
//		midboss.Defence (50);
//		midboss.Defence (60);



	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
