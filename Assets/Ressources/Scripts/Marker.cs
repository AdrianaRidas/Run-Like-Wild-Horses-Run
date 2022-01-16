using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Marker : MonoBehaviour
{
    [SerializeField] private Transform _tip;
    [SerializeField] private int _penSize = 5;

    private Renderer _renderer;
    private Color[] _colors;
    private float _tipHeight;

    private RaycastHit _touch;
    private Taggable _taggable;
    private Vector2 _touchPos, _lastTouchPos;
    private bool _touchedLastFrame;
    private Quaternion _lastTouchRot;
    void Start()
    {
        _renderer = _tip.GetComponent<Renderer>();
        _colors = Enumerable.Repeat(_renderer.material.color, _penSize * _penSize).ToArray();
        _tipHeight = _tip.localScale.y;

    }

    // Update is called once per frame
    void Update()
    {
        Draw();
    }

    private void Draw()
    {

        if (Physics.Raycast(_tip.position, transform.up, out _touch, _tipHeight))
        {
            if (_touch.transform.CompareTag("Taggable"))
            {
                if (_taggable == null)
                {
                    _taggable = _touch.transform.GetComponent<Taggable>();
                }

                _touchPos = new Vector2(_touch.textureCoord.x, _touch.textureCoord.y);

                var x = (int) (_touchPos.x * _taggable.textureSize.x - (_penSize / 2));
                var y = (int) (_touchPos.y * _taggable.textureSize.y - (_penSize / 2));

                if (y < 0 || y > _taggable.textureSize.y || x < 0 || x > _taggable.textureSize.x) return;


                if (_touchedLastFrame)
                {
                    _taggable.texture.SetPixels(x, y, _penSize, _penSize, _colors);

                    for (float f = 0.01f; f < 1.00f; f += 0.01f)
                    {
                        var lerpX = (int) Mathf.Lerp(_lastTouchPos.x, x,f);
                        var lerpY = (int) Mathf.Lerp(_lastTouchPos.y, y,f);
                        _taggable.texture.SetPixels(lerpX, lerpY, _penSize, _penSize, _colors);
                    }


                    transform.rotation = _lastTouchRot;
                    _taggable.texture.Apply();
                }

                _lastTouchPos = new Vector2(x, y);
                _lastTouchRot = transform.rotation;
                _touchedLastFrame = true;
                return;
            }
        }

        _taggable = null;
        _touchedLastFrame = false;
    }
}