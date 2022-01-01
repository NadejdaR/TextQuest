using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
  #region Variables

  public Text ContentTxt;
  public Text LocationTxt;
  public Image LocationImg;
  public StepSO StartStep;

  private StepSO _currentStep;

  #endregion

  #region Unity Lifecicle

  private void Start()
  {
    SetStep(StartStep);
  }

  private void Update()
  {
    int nextStepNum = GetStepNum();

    if (nextStepNum == -1)
      return;

    SetStep(nextStepNum);
  }

  #endregion

  #region Private methods

  private void SetStep(StepSO nextStep)
  {
    if (nextStep == null)
      return;

    _currentStep = nextStep;
    ContentTxt.text = _currentStep.Content;
    LocationTxt.text = _currentStep.Location;
    LocationImg.sprite = _currentStep.LocalImg;
  }

  private void SetStep(int nextStepNumIndex)
  {
    if(IsInvalidIndex(nextStepNumIndex))
      return;
    
    StepSO nextStep = _currentStep.Steps[nextStepNumIndex];
    SetStep(nextStep);
  }

  private bool IsInvalidIndex(int nextStepNumIndex)
  {
    return nextStepNumIndex < 0 || nextStepNumIndex > _currentStep.Steps.Length-1;
  }

  private int GetStepNum()
  {
    if (Input.GetKeyDown(KeyCode.Alpha1)||Input.GetKeyDown(KeyCode.Keypad1))
    {
      return 0;
    }
    if (Input.GetKeyDown(KeyCode.Alpha2)||Input.GetKeyDown(KeyCode.Keypad2))
    {
      return 1;
    }
    if (Input.GetKeyDown(KeyCode.Alpha3)||Input.GetKeyDown(KeyCode.Keypad3))
    {
      return 2;
    }
    if (Input.GetKeyDown(KeyCode.Alpha4)||Input.GetKeyDown(KeyCode.Keypad4))
    {
      return 3;
    }
    if (Input.GetKeyDown(KeyCode.Alpha5)||Input.GetKeyDown(KeyCode.Keypad5))
    {
      return 4;
    }

    return -1;
  }

  #endregion
}