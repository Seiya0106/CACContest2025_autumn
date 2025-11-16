using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Apple", menuName = "Scriptable Objects/Apple")]
public class Apple : ScriptableObject
{
    public List<Image> appleSprites;
    public float interval = 3f;
    public Vector2 spawnPos = new Vector2(700f, 0f);
    public Vector2 destroyPos = new Vector2(-700f, 0f);
    public string appleName;
    public float moveSpeed = -300f;
    public int score = 0;
    public int result = 0;
    public float timeLimit = 30f;
    public bool isPushed = false;
}
