#region License
// ====================================================
// Project Porcupine Copyright(C) 2016 Team Porcupine
// This program comes with ABSOLUTELY NO WARRANTY; This is free software,
// and you are welcome to redistribute it under certain conditions; See
// file LICENSE, which is part of this source code package, for details.
// ====================================================
#endregion

using UnityEditor;
using UnityEngine;

namespace UI.Editor
{
    [CustomEditor(typeof(AutomaticVerticalSize))]
    public class AutomaticVerticalSizeEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();
            if (GUILayout.Button("Recalc Size"))
            {
                AutomaticVerticalSize myScript = (AutomaticVerticalSize)target;
                myScript.AdjustSize();
            }
        }
    }
}
