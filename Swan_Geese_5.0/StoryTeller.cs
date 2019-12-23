using Swan_geese_5._0.BaseClasses;
using Swan_geese_5._0.SubClasses;
using Swan_Geese_5._0.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swan_Geese_5._0
{
    class StoryTeller
    {
        delegate void Order();
        public static void Display_delegate(string message) => Console.WriteLine(message);
        public void TellStrory(Parent parent1, Parent parent2, Child child1, Child brother, Goose goose, Oven oven,
              AppleTree appleTree, MilkRiver milkRiver, GrandParent<Human> grandParent, Mouse mouse)
        {
            Order order = Answers;
            order.Invoke();


            Random rnd = new Random();
            Zmey<Goose, Human> zmey_gorinich = new Zmey<Goose, Human>(3, 213321);

            parent1.Keep_live();
            parent2.Ask(child1);
            parent1.Go_out_from_home();

            Console.WriteLine("  Остаться и поиграть с братиком/Пойти гулять? Введите 1 или 2...");

            string number1 = Console.ReadLine();
            if (number1 == "1")
            {
                Order order1 = child1.Stay_at_home;
                order1();
            }
            else
            {
                Order order2 = child1.Forget;
                order2 += child1.Go_out_from_home;
                order2 += goose.Steal_child;
                order2 += child1.Cry;
                order2 += child1.Search;
                order2 += child1.Run;
                order2 += oven.Keep_staying;
                order2 += child1.Where_brother;
                order2 += oven.Eat_my_cake;
                order2();

                Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                string number2 = Console.ReadLine();
                if (number2 == "1")
                {
                    try
                    {
                        oven.Drop_cake(5, 20);
                        Display_delegate("Печь дала 5 пирожков.");
                        order2 -= child1.Forget;
                        order2 -= child1.Go_out_from_home;
                        order2 -= goose.Steal_child;
                        order2 -= child1.Cry;
                        order2 -= child1.Search;
                        order2 -= child1.Run;
                        order2 -= oven.Keep_staying;
                        order2 -= child1.Where_brother;
                        order2 -= oven.Eat_my_cake;
                        order2 += child1.Eat_cake;
                        order2();
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.WriteLine(ex.Message + "Девочка заблудилась в лесу...");
                    }
                    finally
                    {

                        child1.Come_to_hut();
                    }

                    Order orderfact = delegate
                    {
                        Console.WriteLine("Interested fact: granny Yaga is not just granny =)");
                    };
                    orderfact();    // анонимный метод


                    child1.Do("-Девочка зашла в дом, говорит");
                    child1.Say("-Здравствуй бабушка!");
                    grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                    child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                    grandParent.Say("Садись покуда кудель прясть.");
                    grandParent.Give_spin(grandParent);
                    child1.Spin();
                    mouse.Run();
                    mouse.Ask_to_eat();
                    child1.Give_to_eat();
                    mouse.Ask_to_run();

                    //лямбда
                    Order order3 = () => Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");
                    order3();

                    int c = rnd.Next(1, 2);
                    if (c == 1)
                    {
                        child1.Say("-Спасибо тебе большое, мышка!");
                        child1.Go_out_from_hut();
                        grandParent.Ask_girl(grandParent);
                        mouse.Lie();
                        grandParent.Come_to_hut(grandParent);
                        child1.Ask_oven(oven);
                        oven.Save_children();
                        goose.Not_see();
                        child1.Come_to_home();
                        parent1.Come_to_home();
                    }
                    else
                    {
                        child1.Stay_at_hut();
                    }
                }
                else
                {
                    child1.Not_eat_cake();
                    oven.Go_out_child();
                    appleTree.Keep_staying();
                    child1.Where_brother();
                    appleTree.Eat_my_apple();

                    Console.WriteLine("  Не хочу/С радостью! Введите 1 или 2...");

                    int h = rnd.Next(1, 2);
                    if (h == 2)
                    {
                        child1.Eat_apple();
                        child1.Come_to_hut();
                        child1.Do("-Девочка зашла в дом, говорит");
                        child1.Say("-Здравствуй бабушка!");
                        grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                        child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                        grandParent.Say("Садись покуда кудель прясть.");
                        grandParent.Give_spin(grandParent);
                        child1.Spin();
                        mouse.Run();
                        mouse.Ask_to_eat();
                        child1.Give_to_eat();
                        mouse.Ask_to_run();
                        Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");
                        string c = Console.ReadLine();
                        if (c == "1")
                        {
                            child1.Say("-Спасибо тебе большое, мышка!");
                            child1.Go_out_from_hut();
                            grandParent.Ask_girl(grandParent);
                            mouse.Lie();
                            grandParent.Come_to_hut(grandParent);
                            child1.Ask_apple_tree(appleTree);
                            appleTree.Save_children();
                            goose.Not_see();
                            goose.Fly();
                            oven.Keep_staying();
                            child1.Ask_oven(oven);
                            oven.Eat_my_cake();

                            Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                            string number3 = Console.ReadLine();
                            if (number3 == "1")
                            {
                                child1.Eat_cake();
                                oven.Save_children();
                                goose.Not_see();
                                appleTree.Keep_staying();
                                child1.Ask_apple_tree(appleTree);
                                appleTree.Save_children();
                                goose.Not_see();
                                child1.Come_to_home();
                                parent1.Come_to_home();
                            }
                            else
                            {
                                child1.Not_eat();
                            }
                        }
                        else
                        {
                            child1.Stay_at_hut();
                        }
                    }
                    else
                    {
                        child1.Not_eat_apple();
                        appleTree.Go_out_child();
                        milkRiver.Keep_staying();
                        child1.Where_brother();
                        milkRiver.Drink_my_kissel();

                        Console.WriteLine("  Попить киселя/Пойти дальше? Введите 1 или 2...");
                        string number4 = Console.ReadLine();
                        if (number4 == "1")
                        {
                            child1.Drink_kissel();
                            child1.Come_to_hut();
                            child1.Do("-Девочка зашла в дом, говорит");
                            child1.Say("-Здравствуй бабушка!");
                            grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                            child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                            grandParent.Say("Садись покуда кудель прясть.");
                            grandParent.Give_spin(grandParent);
                            child1.Spin();
                            mouse.Run();
                            mouse.Ask_to_eat();
                            child1.Give_to_eat();
                            mouse.Ask_to_run();

                            Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");

                            int c = rnd.Next(1, 2);
                            if (c == 1)
                            {
                                child1.Say("-Спасибо тебе большое, мышка!");
                                child1.Go_out_from_hut();
                                grandParent.Ask_girl(grandParent);
                                mouse.Lie();
                                grandParent.Come_to_hut(grandParent);
                                child1.Ask_oven(oven);
                                oven.Eat_my_cake();

                                Console.WriteLine("  Скушать пирожок/Пойти дальше? Введите 1 или 2...");

                                string number5 = Console.ReadLine();
                                if (number5 == "1")
                                {
                                    try
                                    {
                                        child1.Eat_cake(); ;
                                    }
                                    catch (NullReferenceException ex)
                                    {
                                        Console.WriteLine(ex.Message + "Налетели гуси-лебеди...");
                                        child1.Not_eat();
                                    }
                                    finally
                                    {
                                        oven.Save_children();
                                    }
                                    goose.Not_see();
                                    appleTree.Keep_staying();
                                    child1.Ask_apple_tree(appleTree);
                                    appleTree.Eat_my_apple();

                                    Console.WriteLine("  Скушать яблочко/Пойти дальше? Введите 1 или 2...");

                                    string number6 = Console.ReadLine();
                                    if (number6 == "1")
                                    {
                                        appleTree.Drop_apple(3, 32);
                                        child1.Eat_apple();
                                        appleTree.Save_children();
                                        goose.Not_see();
                                        milkRiver.Keep_staying();
                                        child1.Ask_river(milkRiver);
                                        milkRiver.Save_children();
                                        goose.Not_see();
                                        child1.Come_to_home();
                                        parent1.Come_to_home();
                                    }
                                    else
                                    {
                                        zmey_gorinich.Fire(goose);
                                        zmey_gorinich.Description("Была умной", "Была глупой", "Самой младшей");
                                        zmey_gorinich.Speak_to_human(child1);
                                        child1.Come_to_home();
                                        parent1.Come_to_home();
                                    }
                                }
                                else
                                {
                                    zmey_gorinich.Fire(goose);
                                    zmey_gorinich.Description("Была умной", "Была глупой", "Самой младшей");
                                    zmey_gorinich.Speak_to_human(child1);
                                    child1.Come_to_home();
                                    parent1.Come_to_home();
                                }

                            }
                            else
                            {
                                child1.Stay_at_hut();
                            }
                        }
                        else
                        {
                            child1.Not_drink_kissel();
                            milkRiver.Go_out_child();
                            child1.Search_in_fields();
                            child1.Come_to_hut();
                            child1.Do("-Девочка зашла в дом, говорит");
                            child1.Say("-Здравствуй бабушка!");
                            grandParent.Say("-Здравствуй, девица! Зачем на глаза явилась?");
                            child1.Say("-Я по мхам, по болотам ходила, платье измочила, пришла погреться.");
                            grandParent.Say("Садись покуда кудель прясть.");
                            grandParent.Give_spin(grandParent);
                            child1.Spin();
                            mouse.Run();
                            mouse.Ask_to_eat();
                            child1.Give_to_eat();
                            mouse.Ask_to_run();

                            Console.WriteLine("  Забрать братика и сбежать/Не поверить мышке и ждать бабулю? Введите 1 или 2...");

                            string c = Console.ReadLine();
                            if (c == "1")
                            {
                                try
                                {
                                    child1.Say("-Спасибо тебе большое, мышка!");
                                }
                                catch when (c == "2")
                                {
                                    child1.Stay_at_hut();
                                }
                                finally
                                {
                                    child1.Go_out_from_hut();
                                }
                                grandParent.Ask_girl(grandParent);
                                mouse.Lie();
                                grandParent.Come_to_hut(grandParent);
                                oven.Keep_staying();
                                child1.Ask_oven(oven);
                                oven.Eat_my_cake();

                                Console.WriteLine("  Скушать пирожок/Пойти дальше?? Введите 1 или 2...");

                                int number5 = rnd.Next(1, 2);
                                if (number5 == 1)
                                {
                                    child1.Eat_cake();
                                    oven.Save_children();
                                    goose.Not_see();
                                    appleTree.Keep_staying();
                                    child1.Ask_apple_tree(appleTree);
                                    appleTree.Eat_my_apple();

                                    Console.WriteLine("  Скушать яблочко/Пойти дальше? Введите 1 или 2...");

                                    string number6 = Console.ReadLine();
                                    if (number6 == "1")
                                    {
                                        try
                                        {
                                            child1.Eat_apple();
                                        }
                                        catch when (number6 == "2")
                                        {
                                            child1.Not_eat();
                                        }
                                        finally
                                        {
                                            appleTree.Save_children();
                                        }
                                        goose.Not_see();
                                        milkRiver.Keep_staying();
                                        child1.Ask_river(milkRiver);
                                        milkRiver.Flowing("речечка");
                                        milkRiver.Drink_my_kissel();

                                        Console.WriteLine("  Попить киселю/Пойти дальше? Введите 1 или 2...");

                                        string number7 = Console.ReadLine();
                                        if (number7 == "1")
                                        {
                                            child1.Drink_kissel();
                                            milkRiver.Save_children();
                                            goose.Not_see();
                                            child1.Come_to_home();
                                            parent1.Come_to_home();
                                        }
                                        else
                                        {
                                            child1.Not_eat();
                                        }
                                    }
                                }
                                else
                                {
                                    child1.Not_eat();
                                }
                            }
                            else
                            {
                                child1.Stay_at_hut();
                            }
                        }
                    }
                }
            }
        }
        public static void Answers()
        {
            Console.WriteLine("Хотите узнать правильные ответы?\n1 - Да      2 - Нет");
            string yes = Console.ReadLine();
            if (yes == "1")
            {
                Console.WriteLine("2, 2, 2, 2, 1, 1, 1, 1 включая рандомы.\n");
            }
            else
            {
                Console.WriteLine("Правильно! Без ответов интересней!\n");
            }
        }
    }
}
