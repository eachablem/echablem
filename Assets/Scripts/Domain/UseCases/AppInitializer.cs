using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class namespace Domain.UseCases : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    
    Public class AppInitializer
    {

    private readonly ISceneLoad  _sceneLoad;

    public AppInitializer(ISceneLoad sceneLoad)
    {
        _sceneLoad = sceneLoad;
        Initialize().Forget();
    }

    private async UnitTaskVoid Initialize()
    {
        await _sceneLoad.LoadSceneAsync("Main");
    }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
