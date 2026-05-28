using UnityEngine;

[CreateAssetMenu(fileName = "StageData",
    menuName = "Game/Stage Data")]
public class StageData : ScriptableObject
{
    public Vector2 playerStartPosition;
}