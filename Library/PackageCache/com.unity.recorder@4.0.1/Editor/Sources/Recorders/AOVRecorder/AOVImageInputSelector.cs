using System;
using UnityEditor.Recorder.AOV.Input;
using UnityEditor.Recorder.Input;
using UnityEngine;

namespace UnityEditor.Recorder.AOV
{
    [Serializable]
    class AOVImageInputSelector : InputSettingsSelector
    {
#pragma warning disable 618
        [SerializeField] public CameraInputSettings cameraInputSettings = new AOVCameraInputSettings();
#pragma warning restore 618
        public ImageInputSettings imageInputSettings
        {
            get { return (ImageInputSettings)Selected; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                if (value is CameraInputSettings)
                {
                    Selected = value;
                }
                else
                {
                    throw new ArgumentException("Video input type not supported: '" + value.GetType() + "'");
                }
            }
        }
    }
}
