using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWhenClose : MonoBehaviour
{
    private Animation _anim;
    private bool _open = false;

    // Start is called before the first frame update
    void Start()
    {
        _anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_anim.isPlaying)
        {
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!_open)
            {
                Debug.Log("Opening chest...");
                _anim.Play("open");
                _open = true;
            }
            else
            {
                Debug.Log("Closing chest...");
                _anim.Play("close");
                _open = false;
            }
        }
    }
}
