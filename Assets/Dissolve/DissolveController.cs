using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveController : MonoBehaviour
{
    [SerializeField] float dissolveAmount;
    [SerializeField] float dissolveSpeed;
    [SerializeField] bool isDissolving;
    [ColorUsage(true, true)]
    [SerializeField] Color fadeOutColor;
    [ColorUsage(true, true)]
    [SerializeField] Color fadeInColor;
    [SerializeField] Material mat;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            isDissolving = true;
        }
        else if (Input.GetKeyDown(KeyCode.S)){
            isDissolving = false;
        }
        if (isDissolving){
            DissolveOut(dissolveSpeed, fadeOutColor);
        }
        else{
            DissolveIn(dissolveSpeed, fadeInColor);
        }
        mat.SetFloat("_DissolveAmount", dissolveAmount);
    }

    void DissolveOut(float speed, Color outlineColor){
        mat.SetColor("_OutlineColor", outlineColor);
        if (dissolveAmount > -0.1){
            dissolveAmount -= Time.deltaTime * speed;
        }
    }

    void DissolveIn(float speed, Color outlineColor){
        mat.SetColor("_OutlineColor", outlineColor);
        if (dissolveAmount < 1.1){
            dissolveAmount += Time.deltaTime * speed;
        }
    }
}
