using UnityEngine;
using pc2unity_30;

 
public class democontroller : MonoBehaviour {

    public pc2unity_30.PointCachePlayer pcp;
 

    void Start() {
        pcp = gameObject.AddComponent<PointCachePlayer>();
        pcp.pointCache = ScriptableObject.CreateInstance<PointCache>();
        pcp.pointCache.Meshes[0].Path = @"D:\AssetStore\pc2unity\Sources\DocumentationDemoTorus\ddtorus0.obj";
        pcp.pointCache.Clips[0].PreImport.FilePath = @"D:\AssetStore\pc2unity\Sources\DocumentationDemoTorus\ddtorus0.obj";
         foreach (TaskInfo currentImportinInfo in pcp.ImportIE()) {
            Debug.Log(currentImportinInfo.Name);    
        }
        pcp.Clip0Weight = 1f;
    }
 
}
