import math, random
class Circulo:
    def __init__(self, raio):
        self.raio = raio
    def Diametro(self):
        return self.raio * 2
    def Perimetro(self):
        return 2 * math.pi * self.raio
    def Area(self):
        return math.pi * math.pow(self.raio, 2)

class Triangulo:
    def __init__(self, l1, l2, l3):
        self.l1 = l1
        self.l2 = l2
        self.l3 = l3
    def Perimetro(self):
        return self.l1 + self.l2 + self.l3
    def Area(self, h):
        return (self.l1 * h) / 2
    def Tipo(self):
        if (self.l1 == self.l2 and self.l2 == self.l3):
            return "equilatero";
        elif (self.l1 != self.l2 and self.l1 != self.l3):
            return "escaleno";
        else:
            return "isoceles";
    







