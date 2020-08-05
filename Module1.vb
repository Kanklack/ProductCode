Module Module1

    Sub Main()

        ' Sets the count to 0 
        Dim Count As Integer = 0

        ' Sets ProductCodeOk to false
        Dim ProductCodeOK As Boolean = False

        'Defines ProductCode as a string 
        Dim ProductCode As String

        'Asks for product code
        Console.Write("Please enter your product code: ")

        'While statement - will only run while ProductCodeOK is False and Count is less than 2 (User only has 2 attempts)
        While ProductCodeOK = False And Count < 2

            'Sets ProductCode to what the user inputs
            ProductCode = Console.ReadLine

            'If the product code is "abcdef" the program will output "Grey socks" and sets ProductCodeOK to true, exiting the while loop.
            If ProductCode = "abcdef" Then

                Console.WriteLine("Grey socks")

                ProductCodeOK = True

                ' If the user doesn't enter "abcdef" the program outputs that the product code is incorrect and asks the user to re-enter the product code.
            Else

                Console.WriteLine("Product code incorrect")

                Console.WriteLine("Please re-enter product code: ")

                'Adds 1 to the count so that when the while loop runs again, the program decides if the count is less than 2, it will run again.
                Count = Count + 1

            End If

        End While

        'If the ProductCodeOk is True, the program will output "Valid product code". 
        If ProductCodeOK = True Then

            Console.WriteLine("Valid product code")

            'If ProductCodeOk is false (i.e Count > 2 / the user has already tried to enter the product code more than twice), the program will output that the maximum amount of attempts has been reached.
        Else

            Console.WriteLine("Maximum attempts reached")

        End If

        'Stops the program from terminating itself.
        Console.Read()

    End Sub

End Module
