using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {
    public Text mainText;
        private enum States
        { shop,
          house_0,
          house_1,
          machine_0,
          bed_0,
          past,
          machine_1,
          house_2,
          bed_1}

    private States myState;

	// Use this for initialization
	void Start () {
        myState = States.shop;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.shop)
            Shop();

        if (myState == States.house_1)
            House_1();

        if (myState == States.house_0)
            House_0();

        if (myState == States.machine_0)
            Machine_0();

        if (myState == States.bed_0)
            Bed_0();

        if (myState == States.past)
            Past();

        if (myState == States.machine_1)
            Machine_1();

        if (myState == States.house_2)
            House_2();

        if (myState == States.bed_1)
            Bed_1();
    }

    private void Shop() {
        mainText.text = "Вы зашли в магазин, Здравствуйте. Есть очень хочется," +
            "но в углу замечаете красную коробку\n\n"
            + "Купить еду - К\n"
            + "Украсть коробку - У\n";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.house_1;
        if (Input.GetKeyDown(KeyCode.E))
            myState = States.house_0;
    }
    private void House_1() {
        mainText.text = "Вы пришли домой, поели и продолжили свою жалкую обывательскую жизнь\n\n";
    }
    private void House_0() {
        mainText.text = "Вы пришли домой. Добро пожаловать, госпожа! Перед вами выбор:\n\n"
            + "Лечь спать - К\n"
            + "Осмотреть коробку - У\n";
        if (Input.GetKeyDown(KeyCode.R))
            myState = States.bed_0;
        if (Input.GetKeyDown(KeyCode.E))
            myState = States.machine_0;
    }
    private void Bed_0() {
        mainText.text = "Вы стырили коробку из общественного места, где это не осталось бы незамеченным\n\n"
            + "вы в своем уме, Анна? Вдруг там бомба? Надо осмотреть коробку и избавиться от нее в случае чего\n"
            + "Вернуться - В\n";
        if (Input.GetKeyDown(KeyCode.D))
            myState = States.house_0;
    }
    private void Machine_0() {
        mainText.text = "Как только вы дотрагиваитесь до коробки, она превращается в огромную машину с кучей кнопок\n\n"
            + "Нажать на большую красную кнопку - Н\n"
            + "Вернуться - В\n";
        if (Input.GetKeyDown(KeyCode.D))
            myState = States.house_0;
        if (Input.GetKeyDown(KeyCode.E))
            myState = States.machine_0;
    }
