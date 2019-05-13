using System;

namespace workspace{
    class program {
        static void main(String[] args){
            int[] numeros = new int[50];
            int num = 0;

            for(int i = 0; i < 50; i++){
                Console.Clear();
                Console.WriteLine("Digite um numero inteiro");
                num = int.Parse(Console.ReadLine());
                numeros[i] = num;
            }
            Console.WriteLine("Digite o valor que deve ser encontrado");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i < 50; i++)
                if(numeros[i] == num)
                    Console.WriteLine("Está presente no vetor");
        }
    }
}

