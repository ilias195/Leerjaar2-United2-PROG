using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; }//get: iedereen kan dit script bekeijken. private set: alleen dit script schrijft

    private void OnEnable()
    {
        Collection.Oncollected += AddScore;
    }

    private void OnDisable()
    {
        Collection.Oncollected -= AddScore;
    }

    private void AddScore(int amount)
    {
        Score += amount;
    }
}
