using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.VersionControl;

public class UI_Assistant : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI boilabel;
    [SerializeField] private string boi;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText()
    {
        boilabel.text = "boi" + boi;
    }















}
