do
            {
                switch (userInput)
                {
                    case Option1:
                        return BookTitle;

                    case Option2:
                        return BookAuthor;

                    case Option3:
                        return BookYear;

                    case Option4:
                        return BookPublishingHouse;

                    default:
                        Console.WriteLine("Ошибка: Вы указали неизвестный параметр! Повторите попытку:");
                        userInput = Console.ReadLine();
                        break;
                }

            } while (userInput != Option1 || userInput != Option2 || userInput != Option3 || userInput != Option4);
