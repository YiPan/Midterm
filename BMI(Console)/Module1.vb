Module Module1

    Sub Main()
        Dim w, h, bmi As Single 'w為體重，h為身高，bmi為BMI值

        Console.Write("請輸入你的體重(kg):")
        w = Console.ReadLine() '將輸入值傳到w

        Console.Write("請輸入你的身高(cm):")
        h = Console.ReadLine() '將輸入值傳到h

        bmi = w / (h / 100) ^ 2
        Console.Write("你的BMI值為:" & bmi) '計算並輸出
        Console.Read()

    End Sub

End Module
