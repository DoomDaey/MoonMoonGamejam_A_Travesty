using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu(fileName = "StoryElements", menuName = "Scriptable Objects/Story/StoryElements")]
public class SO_StoryContainer : ScriptableObject
{
    [SerializeField]
    public List<StoryElementsClass> storyElements;
}
