using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gpm.WebView
{
public class htmlWebView : MonoBehaviour
{

public void ShowUrl(string myStri2) // For viewing HTML files from URL
{
    GpmWebView.ShowUrl(
        myStri2,
        new GpmWebViewRequest.Configuration()
        {
            style = GpmWebViewStyle.FULLSCREEN,
            isClearCookie = false,
            isClearCache = false,
            isNavigationBarVisible = true,
            navigationBarColor = "#4B96E6", // to change colour
            title = "Live HTML.", // Title ?
            isBackButtonVisible = true,
            isForwardButtonVisible = true,
#if UNITY_IOS
            contentMode = GpmWebViewContentMode.MOBILE
#elif UNITY_ANDROID
            supportMultipleWindows = true
#endif
        },
        OnOpenCallback,
        OnCloseCallback,
        new List<string>()
        {
            "USER_ CUSTOM_SCHEME"
        },
        OnSchemeEvent);
}
    
public void ShowHtmlFile(string myS ) // For viewing HTML files from StreamingAssets
    {
    var htmlFilePath = string.Empty;
#if UNITY_IOS
        htmlFilePath = string.Format("file://{0}/{1}", Application.streamingAssetsPath, myS);
#elif UNITY_ANDROID
        htmlFilePath = string.Format("file:///android_asset/{0}", myS);
#endif

    GpmWebView.ShowHtmlFile(
        htmlFilePath,
        new GpmWebViewRequest.Configuration()
        {
            style = GpmWebViewStyle.POPUP, // can FULLSCREEN
            isClearCookie = false,
            isClearCache = false,
            isNavigationBarVisible = true,
            navigationBarColor = "#44F5EC", // Colour
            title = "Loading... " + myS, // change text
            isBackButtonVisible = true,
            isForwardButtonVisible = true,
#if UNITY_IOS
            contentMode = GpmWebViewContentMode.MOBILE
#elif UNITY_ANDROID
            supportMultipleWindows = true
#endif
    },
        OnOpenCallback,
        OnCloseCallback,
        new List<string>()
        {
            "USER_ CUSTOM_SCHEME"
        },
        OnSchemeEvent);
}

private void OnOpenCallback(GpmWebViewError error)
{
    if (error == null)
    {
        Debug.Log("[OnOpenCallback] succeeded.");
    }
    else
    {
        Debug.Log(string.Format("[OnOpenCallback] failed. error:{0}", error));
    }
}

private void OnCloseCallback(GpmWebViewError error)
{
    if (error == null)
    {
        Debug.Log("[OnCloseCallback] succeeded.");
    }
    else
    {
        Debug.Log(string.Format("[OnCloseCallback] failed. error:{0}", error));
    }
}

private void OnSchemeEvent(string data, GpmWebViewError error)
{
    if (error == null)
    {
        Debug.Log("[OnSchemeEvent] succeeded.");
        
        if (data.Equals("USER_ CUSTOM_SCHEME") == true || data.Contains("CUSTOM_SCHEME") == true)
        {
            Debug.Log(string.Format("scheme:{0}", data));
        }
    }
    else
    {
        Debug.Log(string.Format("[OnSchemeEvent] failed. error:{0}", error));
    }
}   
}
}
