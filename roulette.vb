Module roulette

    Sub Main()
        Randomize()

        Dim cash, ball, odds, choice, bet, insNum As Integer
        Dim color As String

        cash = 100
        Console.WriteLine(" Virtual Roulette ")
        Console.WriteLine("you have " & cash.ToString("c"))
        Console.WriteLine("    ")

        While choice <> 7 And cash > 0
            Console.WriteLine("<<<<<<<<<<<<<<<<< ROULETTE >>>>>>>>>>>>>>>>>")
            Console.WriteLine("Place your bet ($" & cash & ")")
            Console.WriteLine("1. Bet on Red (pays 1 to 1)")
            Console.WriteLine("2. Bet on Black (pays 1 to 1)")
            Console.WriteLine("3. First 12 (pays 2 to 1)")
            Console.WriteLine("4. Middle 12 (pays 2 to 1)")
            Console.WriteLine("5. Last 12 (pays 2 to 1)")
            Console.WriteLine("6. Choose any one number (pays 35 to 1)")
            Console.WriteLine("7. Cash out")

            Console.WriteLine("===========================================")
            Console.Write("Enter your choice:")
            choice = Console.ReadLine()

            While choice > 7 Or choice <= 0
                Console.WriteLine(" Please choose from 1 to 7 try again !")
                Console.Write("Enter your choice:")
                choice = Console.ReadLine()
            End While

            ball = Int(37 * Rnd())

            If ball = 0 Then
                color = " Green"
            ElseIf ball Mod 2 = 0 Then
                color = " Black"
            Else : color = " Red"

            End If

            ' bet on red 

            If choice = 1 Then
                Console.WriteLine("Bet On Red >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While
                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()


                Console.WriteLine(ball & color)
                If color = " Red" Then
                    odds = 1
                    cash += bet * odds

                    Console.WriteLine("You won " & bet * odds)
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet

                End If


                ' bet on black 

            ElseIf choice = 2 Then
                Console.WriteLine("Bet On Black >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While

                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()


                Console.WriteLine(ball & color)
                If color = " Black" Then
                    odds = 1
                    cash += bet * odds

                    Console.WriteLine("You won " & bet * odds)
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet
                End If

                ' Bet on 1st 12 
            ElseIf choice = 3 Then
                Console.WriteLine("Bet on 1st 12 >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While
                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()
                Console.WriteLine(ball & color)
                If ball >= 1 And ball <= 12 Then
                    odds = 2

                    Console.WriteLine("You won " & bet * odds)
                    cash += bet * odds
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet



                End If

            ElseIf choice = 4 Then
                Console.WriteLine("Bet on 2nd 12 >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While
                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()
                Console.WriteLine(ball & color)
                If ball >= 13 And ball <= 24 Then
                    odds = 2

                    Console.WriteLine("You won " & bet * odds)
                    cash += bet * odds
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet



                End If


            ElseIf choice = 5 Then
                Console.WriteLine("Bet on 3rd 12 >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While
                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()
                Console.WriteLine(ball & color)
                If ball >= 25 And ball <= 36 Then
                    odds = 2

                    Console.WriteLine("You won " & bet * odds)
                    cash += bet * odds
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet

                End If

            ElseIf choice = 6 Then

                Console.WriteLine("Play Inside one number >>")
                Console.Write("Enter your Bet:")
                bet = Console.ReadLine()
                While bet > cash Or bet <= 0
                    Console.WriteLine("Can't bet more than Cach Amount or bet negative valeu ")
                    Console.Write("Enter your Bet:")
                    bet = Console.ReadLine()
                End While
                Console.Write("Enter a Number to bet on:")
                insNum = Console.ReadLine()
                While insNum > 37 Or insNum < 0
                    Console.WriteLine("Please Enter Number from 0 to 36 only ! Please try again..")
                    Console.Write("Enter a Number to bet on:")
                    insNum = Console.ReadLine()


                End While

                Console.WriteLine("Press Enter to spin...")
                Console.ReadKey()
                Console.WriteLine(ball & color)

                If ball = insNum Then
                    odds = 35

                    Console.WriteLine("You won " & bet * odds)
                    cash += bet * odds
                Else
                    Console.WriteLine("You lost " & bet)
                    cash -= bet



                End If



            End If





            Console.WriteLine("Pess any key to countinue ..")
            Console.ReadKey()
            Console.Clear()
        End While
        Console.WriteLine("Cash Out ! " & vbTab & cash.ToString("c"))

    End Sub

End Module
