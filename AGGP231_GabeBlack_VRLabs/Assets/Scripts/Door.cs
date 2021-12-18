using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public RedKeySpot rk;
    public YellowKeySpot yk;
    public GreenKeySpot gk;
    public BlueKeySpot bk;
    public PurpleKeySpot pk;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rk.collected && yk.collected && gk.collected && bk.collected && pk.collected)
		{
            gameObject.SetActive(false); ;
		}
    }
}
