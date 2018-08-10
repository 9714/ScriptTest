﻿using UnityEngine;
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
		for(int i=0;i<11;i++){
		if (mp >= 5) {
			//残りmpを減らす
			this.mp -= 5;
			Debug.Log ("魔法攻撃をした。残りMPは" + mp);
		} else {
			Debug.Log ("MPが不足");
		}
	}
}
}
		public class Test : MonoBehaviour {

 
			void Start () {
				// Bossクラスの変数を宣言してインスタンスを代入
				Boss lastboss = new Boss ();

				// 攻撃用の関数を呼び出す
				lastboss.Attack();
				// 防御用の関数を呼び出す
				lastboss.Defence(3);
				//魔法用の関数を呼び出す
				lastboss.Magic();
			}

			// Update is called once per frame
 
			void Update () {

			}
		}
