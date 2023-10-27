using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SemanticVersion : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI _versionText;

    public string version;

    private void Awake()
    {
        _versionText.text = version;
    }

}
