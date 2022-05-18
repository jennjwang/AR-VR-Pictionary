using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;
public class Eraser : MonoBehaviour
{
    // Reference to Realtime to use to instantiate brush strokes
    [SerializeField] private Realtime _realtime = null;
    private GameObject _brushStrokePrefab = null;

    public TextMeshProUGUI txt;

    private enum Hand { LeftHand, RightHand };
    [SerializeField] private Hand _hand = Hand.LeftHand;

    // Used to keep track of the current brush tip position and the actively drawing brush stroke
    private Vector3 _handPosition;
    private Quaternion _handRotation;
    public InputDeviceCharacteristics controllerCharacteristics;

    private InputDevice targetDevice;
    void Start()
    {
        // controllerCharacteristics = InputDeviceCharacteristics.Right | InputDeviceCharacteristics.Controller;
        var devices = new List<InputDevice>();

        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        foreach (var item in devices)
        {
            Debug.Log(item.name + item.characteristics);
        }

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    private void Update()
    {
        if (!_realtime.connected)
            return;

        // Start by figuring out which hand we're tracking
        XRNode node = _hand == Hand.LeftHand ? XRNode.LeftHand : XRNode.RightHand;
        string trigger = _hand == Hand.LeftHand ? "Left Trigger" : "Right Trigger";

        // Get the position & rotation of the hand

        // Figure out if the trigger is pressed or not
        bool buttonPressed = targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue == true;



        // // If we lose tracking, stop drawing
        // if (!handIsTracking)
        //     triggerPressed = false;

        // If the trigger is pressed and we haven't created a new brush stroke to draw, create one!
        if (buttonPressed)
        {

            GameObject[] strokes = GameObject.FindGameObjectsWithTag("stroke");

            // txt.text = "pressed";

            for (int i = 0; i < strokes.Length; i++)
            {
                Realtime.Destroy(strokes[i]);
            }

            // txt.text = strokes.Length.ToString();
            // txt.text = (GetComponent<BrushStroke>() != null).ToString();
            //     Destroy(brushStrokeGameObject);

            //     BrushStrokeModel[] objects = UnityEngine.Object.FindObjectsOfType(BrushStrokeModel) as BrushStrokeModel[];


            //     for (int i = 0; i < objects.Length; i++)
            //     {
            //         Realtime.Destroy(objects[i]);
            //     }

            // Realtime.Destroy(_brushStrokePrefab);

            //     // Realtime.Destroy(brushStrokeGameObject);
        }

    }
}
