using UnityEngine;

[CreateAssetMenu(fileName = nameof(StepSO),menuName = "Settings/Step")]
public class StepSO : ScriptableObject
{
  [TextArea(6, 10)] 
  public string Content;

  public string Location;
  public Sprite LocalImg;
  public StepSO[] Steps;

}