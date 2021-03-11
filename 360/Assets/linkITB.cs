using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class linkITB : MonoBehaviour 
{

	public void OpenLinkMuseum()
	{
		#if !UNITY_EDITOR
		openWindow("https://goo.gl/maps/49Ehtg4B2vRazSqR9");
		#endif
	}



	[DllImport("__Internal")]
	private static extern void openWindow(string url);
}