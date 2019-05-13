using System;

namespace workspace{
    class program {
        static void main(String[] args){
            int[] numeros = new int[50];
            int num = 0, pares = 0, impares = 0;

            for(int i = 0; i < 50; i++){
                Console.Clear();
                Console.WriteLine("Digite um numero inteiro");
                num = int.Parse(Console.ReadLine());
                numeros[i] = num;

                if(num%2==0)
                pares++;
                else 
                impares++;
            }
            Console.WriteLine("Numeros pares: "+pares);
            Console.WriteLine("Numeros impares: "+impares);
            
        }
    }
}

