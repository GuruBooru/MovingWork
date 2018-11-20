using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace OpenPose.Example {
	[CustomEditor(typeof(HumanController2D))]
	public class HumanSetting : Editor
	{
		public override void OnInspectorGUI()
		{
			DrawDefaultInspector();
			
			HumanController2D myScript = (HumanController2D)target;
			//if(GUILayout.Button("Run"))
			//{
				//myScript.Run();
			//}
		}
	}
}