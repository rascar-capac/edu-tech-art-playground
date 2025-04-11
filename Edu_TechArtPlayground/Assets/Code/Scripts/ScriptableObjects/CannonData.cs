using UnityEngine;

[CreateAssetMenu]
public class CannonData : ScriptableObject
{
    [SerializeField] private float spawnRate = 1;
    [SerializeField] private float power = 10;

    public float SpawnRate => spawnRate;
    public float Power => power;
}