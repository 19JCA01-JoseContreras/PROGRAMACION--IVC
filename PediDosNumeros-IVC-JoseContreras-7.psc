Algoritmo PediDosNumeros
	Definir num, num2, sum,rest,multi,divi Como Real
	Definir c Como Caracter
	Escribir "Diguite dos numeros: "
	Leer num
	Leer num2
	Escribir "Digame un caracter: "
	Leer c
	Segun c Hacer
		"Sumar" o "suma":
			Escribir "La suma es, ", num+num2
		"Restar" o "Resta":
			Escribir "La resta es, ", num-num2
		"Multiplicacion" o "Multi":
			Escribir "La multi es, ", num*num2
		"Dividir" o "Divi":
			Escribir "La divi es, ", num/num2
		De Otro Modo:
			Escribir "Caracter no encontrado"
	FinSegun
	
FinAlgoritmo
