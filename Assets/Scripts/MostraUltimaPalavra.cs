﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostraUltimaPalavra : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    GetComponent<Text>().text = PlayerPrefs.GetString("ultimaPalavraOculta");
  }
}
