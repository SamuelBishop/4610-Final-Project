using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas ImpactCanvas;
    [SerializeField] float ImpactTime = 2.0f;

    // Start is called before the first frame update
    public void Start()
    {
        ImpactCanvas.enabled = false;
    }

    // Update is called once per frame
    public void ShowDamageImpact()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        ImpactCanvas.enabled = true;
        yield return new WaitForSeconds(ImpactTime);
        ImpactCanvas.enabled = false;
    }
}
