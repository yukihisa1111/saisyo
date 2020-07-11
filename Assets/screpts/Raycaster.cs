using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            //メインカメラ上のマウスカーソルのある位置からRayを飛ばす
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //Vector3 vec = Input.mousePosition;
            //Debug.Log(vec);

            //Rayの長さ
            float maxDistance = 10;

            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction, maxDistance);


            //なにかと衝突した時だけそのオブジェクトの名前をログに出す
            if (hit.collider)
            {
                Debug.Log(hit.collider.gameObject.name);
            }
        }
    }
}
