using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class AddressableLoader : MonoBehaviour
{
    public AssetReference assetReference;

    void Start()
    {
        assetReference.LoadAssetAsync<GameObject>().Completed += OnAssetLoaded;
    }

    void OnAssetLoaded(AsyncOperationHandle<GameObject> handle)
    {
        if (handle.Status == AsyncOperationStatus.Succeeded)
        {
            Instantiate(handle.Result);
        }
    }
}
