using UnityEngine;
using UnityEngine.UI;

public class KarakterMove : MonoBehaviour
{
    public Rigidbody rb;
    public float addForce = 2000f;
    public float sagSaol = 500f;
    private float screnWdith;
    private void Start()
    {
        screnWdith = Screen.width;
    }

    void FixedUpdate()
    {
#if UNITY_EDITOR
        RunChacter(Input.GetAxis("Horizontal"));
#endif

        if (rb.position.y>0)
        {
          rb.AddForce(0, 0, addForce * Time.deltaTime);
        }
        int i = 0;

        while (i < Input.touchCount)
        {
            if (Input.GetTouch(i).position.x > screnWdith / 2)
            {
                RunChacter(1.0f);
            }
            if (Input.GetTouch(i).position.x < screnWdith / 2)
            {
                RunChacter(-1.0f);
            }
            i++;
        }






        /* if (Input.GetKey("d"))
         {
             rb.AddForce(sagSaol * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
         }
         if (Input.GetKey("a"))
         {
             rb.AddForce(-sagSaol * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
         }*/
        if (rb.position.y<-1f)
        {   
            FindObjectOfType<GameMenajer>().GameEnd();  
        }
    }
   

    public void SetSpeed(int modifer)
    {
        addForce = 300.0f + modifer;
    }

    private void RunChacter(float horizontalInput)
    {
        rb.AddForce(horizontalInput *sagSaol* Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
