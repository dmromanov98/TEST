using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCreator : MonoBehaviour
{
    private Vector3 _currentPosition = new Vector3();

    public int numberOfPinsOnTheBottomLayer = 4;
    public GameObject pin;
    public GameObject parent;

    private float _pinSpacingY;
    private float _pinSpacingZ;

    void Start()
    {
        if (!parent.activeSelf) return;

        var scales = pin.transform.localScale;
        _pinSpacingY = scales.y * 2;
        _pinSpacingZ = scales.z + scales.z / 5;
        for (var i = 0; i < numberOfPinsOnTheBottomLayer; i++)
        {
            _currentPosition = new Vector3(0,
                scales.y + _pinSpacingY * i,
                0 - (_pinSpacingZ * (numberOfPinsOnTheBottomLayer - i)) / 2);
            
            for (var j = 0; j < numberOfPinsOnTheBottomLayer - i; j++)
            {
                pin.transform.position = _currentPosition;
                Instantiate(pin, parent.transform);
                _currentPosition += new Vector3(0, 0, _pinSpacingZ);
            }
        }
    }
}