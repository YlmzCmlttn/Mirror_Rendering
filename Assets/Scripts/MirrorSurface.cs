using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MirrorSurface : MonoBehaviour
{
    public ProjectionPlane m_ProjectionPlane;
    // Start is called before the first frame update
    void Start()
    {
        m_ProjectionPlane.m_PlaneSize.x = transform.localScale.x;
        m_ProjectionPlane.m_PlaneSize.y = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.hasChanged) {
            m_ProjectionPlane.m_PlaneSize.x = transform.localScale.x;
            m_ProjectionPlane.m_PlaneSize.y = transform.localScale.y;
        }
    }
}
