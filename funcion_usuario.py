
# Función para calcular el promedio de tres números
def calcular_promedio(num1, num2, num3):
    promedio = (num1 + num2 + num3) / 3
    return promedio

# Programa principal
print("Calcula el promedio de tres números")
a = float(input("Ingrese el primer número: "))
b = float(input("Ingrese el segundo número: "))
c = float(input("Ingrese el tercer número: "))

resultado = calcular_promedio(a, b, c)
print(f"El promedio es: {resultado}")
