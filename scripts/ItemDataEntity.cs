using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemDataEntity : ScriptableObject
{
   public List<Item> items = new List<Item>();
}
