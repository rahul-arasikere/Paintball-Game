using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectEnemy : MonoBehaviour
{
    private Vector3 _startScale;
    private Highlight _highlight;
    // Start is called before the first frame update
    void Start()
    {
        _startScale = transform.localScale;
        _highlight = GetComponent<Highlight>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SeesEnemy())
        {
            transform.localScale = _startScale * 1.5f;
            _highlight.ShowHighlight(true);
        }
        else
        {
            transform.localScale = _startScale;
            _highlight.ShowHighlight(false);
        }
    }

    private bool SeesEnemy()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            if (hit.transform.gameObject.tag == "Enemy")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
