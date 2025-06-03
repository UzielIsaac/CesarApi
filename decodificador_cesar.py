def decodificar_cesar(texto, desplazamiento):
    resultado = ""
    for caracter in texto:
        if caracter.isalpha():
            base = ord('A') if caracter.isupper() else ord('a')
            resultado += chr((ord(caracter) - base - desplazamiento) % 26 + base)
        else:
            resultado += caracter
    return resultado

# Ejemplo de uso
mensaje_codificado = "Khoor Zruog"
desplazamiento = 3
print("Mensaje decodificado:", decodificar_cesar(mensaje_codificado, desplazamiento))

