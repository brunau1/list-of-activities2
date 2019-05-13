using System;

namespace workspace{
    class program {
        static void main(String[] args){
            float[] v = new float[10];
            int num = 0, contOcorrencia = 0;

            for(int i = 0; i < 10; i++){
                Console.Clear();
                Console.WriteLine("Digite um numero");
                num = int.Parse(Console.ReadLine());
                v[i] = num;
            }
            Console.WriteLine("Digite um numero inteiro");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i < 10; i++)
                if(v[i]==num)
                contOcorrencia ++;

            Console.WriteLine("O valor ocorre "+contOcorrencia+" vezes no vetor");
        }
    }
}

