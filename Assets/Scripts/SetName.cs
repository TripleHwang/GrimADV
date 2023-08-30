using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;
using TMPro;

public class SetName : MonoBehaviour
{
    public TMP_InputField field;
    // Start is called before the first frame update

    public void SetCharName(GameObject cha)
    {
        cha.GetComponent<Character>().NameText = field.text;
    }
}
