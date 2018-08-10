using UnityEngine;
using System.Collections;

public class Boss {        
	private int mp = 53;           // 魔法   
	private int hp = 100;         // 体力
	private int power = 25;      // 攻撃力

		// 攻撃用の関数
		public void Attack() { 
			Debug.Log( this.power + "のダメージを与えた" );
		}
	    // 防御用の関数
		public  void Defence(int damage) { 
			Debug.Log( damage+"のダメージを受けた" );
			// 残りhpを減らす
			this.hp -= damage;
		}
	    // 魔法用の関数
	    public void Magic() { 
		
		if (mp >= 5) {
			//残りmpを減らす
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが不足");
		}
	}
}


		public class Test : MonoBehaviour {

	void Start () {
				
		// 要素数5の配列を初期化する
		int[] points = new int[6];
		// 配列の各要素に値を代入する
		points [1] = 20;
		points [2] = 50;
		points [3] = 10;
		points [4] = 80;
		points [5] = 30;
		//順番に並べる
    	for (int j = 1; j < 6; j++) {
				Debug.Log (points [j]);
			}
		//逆順に並べる
		for (int k = 5; k >0; k--) {
			Debug.Log (points [k]);
		}
		// Bossクラスの変数を宣言してインスタンスを代入
				Boss lastboss = new Boss ();

				// 攻撃用の関数を呼び出す
				lastboss.Attack();
				// 防御用の関数を呼び出す
				lastboss.Defence(3);
				//魔法用の関数を呼び出す
		for(int i=0;i<11;i++){
			lastboss.Magic();
		
			}
	}
			// Update is called once per frame
 
			void Update () {

			}
		}
