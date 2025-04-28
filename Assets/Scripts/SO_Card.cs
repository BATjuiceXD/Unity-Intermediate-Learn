using System;
using UnityEngine;
using NaughtyAttributes;

[CreateAssetMenu (menuName = "Profile/Card")]
public class SO_Card : ScriptableObject
{
    [Header("Characterinfo")]
    public string Name;
    public int Health;
    public int Atk;
    public string Description;
    public Type ElementalType;
    public int Cost;

    public Sprite CharacterImage;
}
public enum Type
{
    Fire,
    Ice,
    Wind,
    Lightning,
    Earth,
    Water
}
