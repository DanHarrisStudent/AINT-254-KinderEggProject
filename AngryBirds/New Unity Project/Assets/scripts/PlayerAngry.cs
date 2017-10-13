using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngry : MonoBehaviour {

    [SerializeField]
    private GameObject m_dot;

    private GameObject[] m_dotline;

    private Transform m_transform;

    private Vector3 m_direction;

    [SerializeField]
    private float m_force = 8.0f;

    private Rigidbody m_rigidbody;


	// Use this for initialization
	void Start () {

        m_transform = transform;
        m_rigidbody = GetComponent<Rigidbody>();

        //Set the size of the array
        m_dotline = new GameObject[10];

        //Fills the array with dot prefab
        for (int i = 0; i < m_dotline.Length; i++)
        {
            GameObject tempObj = Instantiate(m_dot);
            tempObj.SetActive(false);
            m_dotline[i] = tempObj;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Click and drag
        if (Input.GetMouseButton(0))
        {
            Vector3 characterPosition = Camera.main.WorldToScreenPoint(m_transform.position);
            characterPosition.z = 0;

            m_direction = (characterPosition - Input.mousePosition).normalized;

            Aim();
        }
        if (Input.GetMouseButtonUp(0))
        {
            m_rigidbody.velocity = m_direction * m_force;
            for (int i = 0; i < m_dotline.Length; i++)
            {
                m_dotline[i].SetActive(false);
            }
        }
	}

    private void Aim()
    {
        //Velocity of x axis
        float Vx = m_direction.x * m_force;

        //Velocity of y axis
        float Vy = m_direction.y * m_force;

        for (int i = 0; i < m_dotline.Length; i++)
        {
            float t = i * 0.1f;
            m_dotline[i].transform.position = new Vector3(m_transform.position.x + Vx * t, (m_transform.position.y + Vy * t) - (0.5f * 9.8f * t * t), 0.0f);

            m_dotline[i].SetActive(true);
        }


    }
}
