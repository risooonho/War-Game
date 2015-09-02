using UnityEngine;
using System.Collections;

public class TurretFireControll : MonoBehaviour {

	public GameObject weapon;
	LineRenderer line;

	float reloadTime = 50f; //ms
	float reload = 50f;

	void Start () {
		line = gameObject.GetComponent<LineRenderer> ();
		line.enabled = true;
	}

	void Update () {
		Ray ray = new Ray (this.transform.position, this.transform.forward);
		RaycastHit hit = new RaycastHit ();
		line.SetPosition (0, ray.origin);

		if(Physics.Raycast(ray,out hit , 300) && reload == reloadTime){
			if(hit.transform.tag.Equals("Player")){
				line.SetPosition(1, hit.point);
				GameObject w = (GameObject) Instantiate(weapon, this.transform.position, this.transform.rotation);
				EnemyShoot es = w.GetComponent<EnemyShoot>();
				es.target = hit.point;
				this.reload = 0;
			}
		}
		else{
			line.SetPosition(1, ray.GetPoint(500));
			if(reload < reloadTime)
			reload++;
		}
	}
}
