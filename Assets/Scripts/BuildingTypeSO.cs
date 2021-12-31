using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject
{
    public string nameString; // name field is already used by Scriptable Object Class
    public Transform prefab;
    public ResourceGeneratorData resourceGeneratorData;
}
