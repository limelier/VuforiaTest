using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateWhenClose : MonoBehaviour
{
    private Animation _anim;
    private bool _open = false;
    private Camera _camera;

    // Start is called before the first frame update
    private void Start()
    {
        _anim = gameObject.GetComponent<Animation>();
        _camera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        if (_anim.isPlaying)
        {
            return;
        }

        var delta = _camera.transform.position - gameObject.transform.position;
        var distanceMeters = delta.magnitude;

        if (distanceMeters > 0.3 && _open)
        {
            _anim.Play("close");
            _open = false;
        }
        else if (distanceMeters < 0.3 && !_open)
        {
            _anim.Play("open");
            _open = true;
        }
    }
}
