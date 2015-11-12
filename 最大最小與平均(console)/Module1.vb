Module Module1

    Sub Main()

        Dim i, num, sum As Integer 'i是迴圈的記數變數 , num為總個數 , sum 為所有值的加總

        Console.Write("請輸入總個數:")
        num = Val(Console.ReadLine()) '將輸入個數傳回num

        Dim h(num - 1) As Integer 'h是陣列

        For i = 0 To h.GetUpperBound(0) '利用迴圈將所有的值放到陣列中
            Console.Write("請輸入第{0}的值:", (i + 1).ToString())
            h(i) = Val(Console.ReadLine())
        Next

        For Each a As Integer In h
            sum += a
        Next '計算平均值

        Console.Write("平均值為:{0}", CInt((sum / num)).ToString())
        Console.WriteLine()

        Console.Write("最大值為:{0}", GetMax(h).ToString())
        Console.WriteLine()

        Console.Write("最小值為:{0}", GetMin(h).ToString())
        Console.WriteLine()

        Console.Read() '輸出最大值、最小值及平均值
    End Sub
    Function GetMax(ByVal ParamArray h() As Integer) As Integer

        Dim max As Integer

        max = h(0)

        For i As Integer = 1 To h.Length - 1 '利用迴圈跟IF把最大值找出來
            If h(i) > max Then
                max = h(i)
            End If
        Next

        Return max

    End Function
    Function GetMin(ByVal ParamArray h() As Integer) As Integer

        Dim min As Integer

        min = h(0)

        For i As Integer = 1 To h.Length - 1 '利用迴圈跟IF把最小值找出來
            If h(i) < min Then
                min = h(i)
            End If
        Next

        Return min

    End Function

End Module
