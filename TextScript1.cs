using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript1 : MonoBehaviour {

	public Text mainText;

	private enum States
	{
		shop,
		house_0,
		house_1,
		machine_0,
		bed_0,
		past,
		machine_1,
		house_2,
		bed_1
	}

	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.shop;
	}
	
	// Update is called once per frame
	void Update () {
		if (myState == States.shop)
			Shop ();
		if (myState == States.house_1)
			House_1 ();
		if (myState == States.house_0)
			House_0 ();
		if (myState == States.machine_0)
			Machine_0 ();
		if (myState == States.bed_0)
			Bed_0 ();
		if (myState == States.past)
			Past ();
		if (myState == States.machine_1)
			Machine_1 ();
		if (myState == States.house_2)
			House_2 ();
		if (myState == States.bed_1)
			Bed_1 ();
	}

	private void Shop(){
		mainText.text = "Вы зашли в магазин. Здравствуйте. Есть очень хочется,"+
			"но вдруг вы замечает блестящую красную коробку.\n\n"+
			"Купить еду - К\n"+
			"Украсть коробку и убежать - У\n";

		if (Input.GetKeyDown(KeyCode.R))
			myState = States.house_1;
		if (Input.GetKeyDown(KeyCode.E))
			myState = States.house_0;
	}

	private void House_1(){
		mainText.text = "Вы пришли домой, поели и продолжили свою жалкую жизнь.\n\n Конец";

	}

	private void House_0(){
		mainText.text = "Вот Вы и дома. Вы устали как осел. Украденная коробка лежит в углу."+
			"Кровать манит спать.\n\n"+
			"Осмотреть кровать - О\n"+
			"Подойти к коробке - П\n";

		if (Input.GetKeyDown(KeyCode.J))
			myState = States.bed_0;
		if (Input.GetKeyDown(KeyCode.G))
			myState = States.machine_0;
	}

	private void Bed_0(){
		mainText.text = "Вы хотите спать, но еще больше вы хотите есть. Поэтому вы не будете спать\n\n" +
		"Вернуться - В\n";

		if (Input.GetKeyDown(KeyCode.D))
			myState = States.house_0;

	}

	private void Machine_0(){
		mainText.text = "Как только Вы дотрагиваетесь до коробки, она превращется в огромную машину с кучей кнопок\n\n" +
		"Вернуться - В\n" +
		"Нажать на случайную кнопку - С\n" +
		"Нажать на большую красную кнопку - К\n";

		if (Input.GetKeyDown(KeyCode.D))
			myState = States.house_0;
		if (Input.GetKeyDown(KeyCode.C))
				myState = States.past;
		if (Input.GetKeyDown(KeyCode.R))
			myState = States.machine_1;
	}

	private void Past(){
		mainText.text = "Ого. Вы попали в прошлое. На три дня назад" +
		"Вы видите себя пьющего Денеб. Вы кидаетесь с объятьями." +
		"Время не выдерживает такого поворота. Вселенная уничтожена.";

	}

	private void Machine_1() {
		mainText.text = "Машина потухает. И больше ничего не нажимается\n\n" +
		"Вернуться - В\n";

		if (Input.GetKeyDown(KeyCode.D))
			myState = States.house_2;

	}

	private void House_2(){
		mainText.text = "Вашего дома больше нет.Всюду плакаты голубей в пиджаках."+
			"Выбери Курлыка или умри - гласят заголовки."+
			"Как ни странно справа лежит ваша кровать\n\n"+
			"Осмотреть кровать - О\n"+
			"Подойти к машине - П\n";

		if (Input.GetKeyDown(KeyCode.J))
			myState = States.bed_1;
		if (Input.GetKeyDown(KeyCode.G))
			myState = States.machine_1;
	}

	private void Bed_1(){
		mainText.text = "На кровате вас ждет голубь в костюме кролика. Он умирает.\n" +
		"-Человек, дай мне пить?\n А у вас ничего нет.\n -Тогда выпью вашей крови.\n" +
		"Конец";
	}


}
