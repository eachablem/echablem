using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Domain.Services;
using UnityEngine.SceneManagement;

namespace App.services
public class UnitySceneLoad : ISceneLoad
{
    // Start is called before the first frame update
    void Start()
    public Unitaks<Float> LoadSceneSyn(string sceneName)
    { 
        private AsyncOperation _asyncOperation;
        public async Unitaks LoadSceneAsync(string sceneMane)
    {

        _asyncOperation = SceneManager.LoadSceneAsync(sceneMane);
        _asyncOperation.allowSceneActivation = false;

        while (_asyncOperation.progress <= 0.89)
        {
            await Taks.Yield();
        }
        _asyncOperation.allowSceneActivation = true;
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
