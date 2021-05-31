using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static Constants;

public class ShowKeyPress : MonoBehaviour
{
  private SpriteRenderer spriteRenderer;
  private bool mirrored;
  private bool pressed;

  public KeyCode key;

  public ShowKeyPress(KeyCode key)
  {
    this.key = key;
  }

  public bool Mirrored
  {
    get => mirrored;
    set => mirrored = value;
  }

  public bool Pressed { get => pressed; set => pressed = value; }

  // Start is called before the first frame update
  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
    spriteRenderer.color = Color.white;
  }

  // Update is called once per frame
  void Update()
  {
    checkMirrored();
    checkPressed();
    if (pressed) spriteRenderer.color = mirrored ? Color.blue : Color.green;
    else spriteRenderer.color = Color.white;
  }

  private void checkMirrored()
  {
    if (Input.GetKeyDown(KEY_MIRROR)) mirrored = true;
    else if (Input.GetKeyUp(KEY_MIRROR)) mirrored = false;
    // if (mirrored) print("keyboard is " + (mirrored ? "" : "NOT ") + "mirrored");
  }

  private void checkPressed()
  {
    if (Input.GetKeyDown(key)) pressed = true;
    else if (Input.GetKeyUp(key)) pressed = false;
    // if (pressed) print("key is " + (pressed ? "" : "NOT ") + "pressed");
  }
}
