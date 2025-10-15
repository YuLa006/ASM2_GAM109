using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace ASM1
{
    internal class ASM2
    {
        static void Main(string[] args)
        {

            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8; 

            string pathAccount = @"D:\GAM109\Code\File txt\Account.txt";
            string pathPlayer = @"D:\GAM109\Code\File txt\Player.txt";
            string pathItem = @"D:\GAM109\Code\File txt\Item.txt";
            string pathQuest = @"D:\GAM109\Code\File txt\Quest.txt";

            // Tạo file txt
            //if (!File.Exists(pathFile))
            //{
            //    File.Create(pathFile).Close(); // tạo file rỗng nếu chưa có
            //}

            // Account
            List<Account> acc = new List<Account>();
            var line = File.ReadAllLines(pathAccount);
            for (int i = 1; i < line.Length; i++)
            {
                //    //Mỗi một line[i] này tương ứng với 1 dòng
                //    //split - phương thức này là tách 1 chuỗi thành các phần tử theo điều kiện chung nào đó => mảng các phần tử
                var part = line[i].Split('\t');

                //gán dữ liệu trong file txt cho biến 
                if (part.Length >= 6)
                {
                    Account act = new Account()
                    {
                        AccountID = part[0],
                        Username = part[1],
                        Email = part[2],
                        PasswordHash = part[3],
                        RegistrationDate = DateTime.Parse(part[4]),
                        LastLogin = DateTime.Parse(part[5])
                    };
                    acc.Add(act);
                }
            }

            // Player
            List<Player> pl = new List<Player>();
            var player = File.ReadAllLines(pathPlayer);
            for (int i = 1; i < player.Length; i++)
            {
                var p = player[i].Split('\t');

                if(p.Length >= 9)
                {
                    Player plr = new Player()
                    {
                        playerID = p[0],
                        accountID = p[1],
                        playerName = p[2],
                        Level = Convert.ToInt32(p[3]),
                        Experience = Convert.ToInt32(p[4]),
                        health =  Convert.ToInt32(p[5]),
                        mana = Convert.ToInt32(p[6]),
                        Class = p[7],
                        creationDate = DateTime.Parse(p[8]),   
                    };
                    pl.Add(plr);
                }
            }

            //Item
            List<Item> items = new List<Item>();
            var itm = File.ReadAllLines(pathItem);
            for (int i = 1; i < itm.Length; i++)
            {                
                var part = itm[i].Split('\t');
                if (part.Length >= 9)
                {
                    Item itr = new Item()
                    {
                        iteamID = part[0],
                        itemName = part[1],
                        itemType = part[2],
                        description = part[3],
                        attackPower = int.Parse(part[4]),
                        defensePower = int.Parse(part[5]),
                        vaule = int.Parse(part[6]),
                        rarity = part[7],
                        ownerPlayerID = part[8],
                    };
                    items.Add(itr);
                }
            }

            //Quest
            List<Quest> quests = new List<Quest>();
            var readQuest = File.ReadAllLines(pathQuest);
            for (int i = 1; i < readQuest.Length; i++)
            {
                var part = readQuest[i].Split('\t');                
                    if (part.Length >= 11)
                    {
                        Quest qst = new Quest()
                        {
                            QuestID = part[0],
                            QuestName = part[1],
                            Description = part[2],
                            QuesType = part[3],
                            difficulty = part[4],
                            experienceReward = int.Parse(part[5]),
                            GoldReward = int.Parse(part[6]),
                            status = part[7],
                            requiredItemID = part[8],
                            rewardItemID = part[9],
                            AssigneePlayerID = part[10],
                        };
                        quests.Add(qst);                    
                }
            }

            // in ra thông tin
            Console.WriteLine("------------Account-----------");
            foreach (var a in acc)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("\n------------Player-----------");
            foreach (var p in pl)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n------------Item-----------");
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n------------Quest-----------");
            foreach (var q in quests)
            {
                Console.WriteLine(q);
            }

            while (true)
            {
                Console.WriteLine("\n----------------------------------------Mục lục---------------------------------------------------------------");
                Console.WriteLine("Câu 1:Liệt kê tất cả tên người chơi (PlayerName) có Level lớn hơn 55.");                
                Console.WriteLine("Câu 2:Đếm số lượng vật phẩm (Item) có Rarity là Legendary.");
                Console.WriteLine("Câu 3:Tìm thông tin người chơi (Player) đầu tiên trong danh sách có Class là Mage. Nếu không có, trả về null.");
                Console.WriteLine("Câu 4:Liệt kê tên tất cả các nhiệm vụ (QuestName) theo thứ tự bảng chữ cái giảm dần.");
                Console.WriteLine("Câu 5:Kiểm tra xem có bất kỳ tài khoản (Account) nào được đăng ký (RegistrationDate) trong năm 2023 không.");
                Console.WriteLine("Câu 6:Lấy thông tin người chơi (Player) cuối cùng trong danh sách players (dựa trên thứ tự hiện tại trong list.");
                Console.WriteLine("Câu 7:Tạo một Dictionary<string, string> trong đó key là AccountID và value là Username của tài khoản.");
                Console.WriteLine("Câu 8:Liệt kê tên của tất cả các vật phẩm (ItemName) mà người chơi có PlayerName là Aragorn đang sở hữu.");
                Console.WriteLine("Câu 9:Lấy danh sách tất cả các ItemType của vật phẩm (Item) mà không bị trùng lặp, sắp xếp theo bảng chữ cái.");
                Console.WriteLine("Câu 10:Hiển thị PlayerName và QuestName của tất cả các nhiệm vụ đang có trạng thái InProgress. Kết quả là một danh sách các đối tượng ẩn danh hoặc một class tùy chỉnh.");
                Console.WriteLine("Câu 11:Tạo một ILookup<string, Player> nhóm tất cả người chơi theo Class của họ.");
                Console.WriteLine("Câu 12:Đếm số lượng vật phẩm (Item) mà mỗi ItemType có. Hiển thị ItemType và số lượng.");
                Console.WriteLine("Câu 13:Liệt kê tất cả PlayerName của những người chơi đang thực hiện ít nhất một nhiệm vụ (Quest) có Difficulty là Hard. Đảm bảo tên người chơi không bị trùng lặp.");
                Console.WriteLine("Câu 14:Tìm tất cả các người chơi (Player) không được giao bất kỳ nhiệm vụ (Quest) nào. ");
                Console.WriteLine("Câu 15:Liệt kê tên người chơi (PlayerName) và tổng ExperienceReward từ tất cả các nhiệm vụ (Quest) mà mỗi người chơi đã hoàn thành (Status == Completed). Chỉ hiển thị những người chơi có tổng ExperienceReward lớn hơn 100000. Sắp xếp kết quả theo tổng ExperienceReward giảm dần.");
                Console.WriteLine("Câu 16:Đối với mỗi Account, hãy liệt kê Username của tài khoản và danh sách tên các nhân vật (PlayerName) thuộc tài khoản đó, nhưng chỉ những nhân vật có Level từ 30 trở lên. ");
                Console.WriteLine("Câu 17:(Sử dụng SelectMany) Tìm tất cả các cặp vật phẩm (Item) mà một người chơi (Player) có thể trang bị, trong đó một vật phẩm là Weapon (ví dụ ItemType chứa Sword, Axe, Bow, Staff, Dagger, Wand, Hammer) và vật phẩm kia là Armor hoặc Shield. Hiển thị PlayerName, tên vũ khí, và tên giáp/khiên.");
                Console.WriteLine("Câu 18:Tìm QuestType có tổng GoldReward cao nhất từ các nhiệm vụ đã Completed. Hiển thị QuestType và tổng GoldReward đó.");
                Console.WriteLine("Câu 19:Tính Chỉ số Quest Hoàn thành cho mỗi người chơi, sau đó liệt kê 3 người chơi có chỉ số này cao nhất.");
                Console.WriteLine("Câu 20:Tìm những người chơi (Player) đã được giao ít nhất một nhiệm vụ (Quest) yêu cầu một vật phẩm (RequiredItemID không null) và họ đang sở hữu vật phẩm đó. Hiển thị PlayerName, QuestName, và ItemName của vật phẩm yêu cầu.");

                Console.Write("\nMời bạn chọn 1 mục: ");
                int chon = Convert.ToInt32(Console.ReadLine());
               
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Câu 1:Liệt kê tất cả tên người chơi (PlayerName) có Level lớn hơn 55.");
                        var cau1 = pl.Where(p => p.Level > 55).Select(p => p.playerName);
                        foreach (var p in cau1)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Câu 2:Đếm số lượng vật phẩm (Item) có Rarity là Legendary.");
                        var cau2 = items.Count(i => i.rarity == "Legendary");
                        Console.WriteLine($"Số lượng vật phẩm có Rarity là Legendary: {cau2}");
                        break;
                    case 3:
                        Console.WriteLine("Câu 3:Tìm thông tin người chơi (Player) đầu tiên trong danh sách có Class là Mage. Nếu không có, trả về null.");
                        var cau3 = pl.FirstOrDefault( p => p.Class == "Mage");
                        Console.WriteLine(cau3?.ToString() ?? "Null");                       
                        break;
                    case 4:
                        Console.WriteLine("Câu 4:Liệt kê tên tất cả các nhiệm vụ (QuestName) theo thứ tự bảng chữ cái giảm dần.");
                        var cau4 = quests.OrderByDescending(q => q.QuestName).Select(q => q.QuestName);
                        foreach(var q in cau4)
                        {
                            Console.WriteLine(q);
                        }    
                        break;
                    case 5:
                        Console.WriteLine("Câu 5:Kiểm tra xem có bất kỳ tài khoản (Account) nào được đăng ký (RegistrationDate) trong năm 2023 không.");
                        var cau5 = acc.Any(a => a.RegistrationDate.Year == 2023);
                        Console.WriteLine(cau5);
                        break;
                    case 6:
                        Console.WriteLine("Câu 6:Lấy thông tin người chơi (Player) cuối cùng trong danh sách players (dựa trên thứ tự hiện tại trong list.");
                        var cau6 = pl.LastOrDefault();
                        Console.WriteLine(cau6.ToString());
                        break;
                    case 7:
                        Console.WriteLine("Câu 7:Tạo một Dictionary<string, string> trong đó key là AccountID và value là Username của tài khoản.");
                        var cau7 = acc.ToDictionary(a => a.AccountID, b => b.Username);
                        foreach (var a in cau7)
                        {
                            Console.WriteLine(a.ToString());
                        }    
                        break;
                    case 8:
                        Console.WriteLine("Câu 8:Liệt kê tên của tất cả các vật phẩm (ItemName) mà người chơi có PlayerName là Aragorn đang sở hữu.");

                        break;
                    case 9:
                        Console.WriteLine("Câu 9:Lấy danh sách tất cả các ItemType của vật phẩm (Item) mà không bị trùng lặp, sắp xếp theo bảng chữ cái.");
                        break;
                    case 10:
                        Console.WriteLine("Câu 10:Hiển thị PlayerName và QuestName của tất cả các nhiệm vụ đang có trạng thái InProgress. Kết quả là một danh sách các đối tượng ẩn danh hoặc một class tùy chỉnh.");
                        break;
                    case 11:
                        Console.WriteLine("Câu 11:Tạo một ILookup<string, Player> nhóm tất cả người chơi theo Class của họ.");
                        break;
                    case 12:
                        Console.WriteLine("Câu 12:Đếm số lượng vật phẩm (Item) mà mỗi ItemType có. Hiển thị ItemType và số lượng.");
                        break;
                    case 13:
                        Console.WriteLine("Câu 13:Liệt kê tất cả PlayerName của những người chơi đang thực hiện ít nhất một nhiệm vụ (Quest) có Difficulty là Hard. Đảm bảo tên người chơi không bị trùng lặp.");
                        break;
                    case 14:
                        Console.WriteLine("Câu 14:Tìm tất cả các người chơi (Player) không được giao bất kỳ nhiệm vụ (Quest) nào. ");
                        break;
                    case 15:
                        Console.WriteLine("Câu 15:Liệt kê tên người chơi (PlayerName) và tổng ExperienceReward từ tất cả các nhiệm vụ (Quest) mà mỗi người chơi đã hoàn thành (Status == Completed). Chỉ hiển thị những người chơi có tổng ExperienceReward lớn hơn 100000. Sắp xếp kết quả theo tổng ExperienceReward giảm dần.");
                        break;
                    case 16:
                        Console.WriteLine("Câu 16:Đối với mỗi Account, hãy liệt kê Username của tài khoản và danh sách tên các nhân vật (PlayerName) thuộc tài khoản đó, nhưng chỉ những nhân vật có Level từ 30 trở lên. ");
                        break;
                    case 17:
                        Console.WriteLine("Câu 17:(Sử dụng SelectMany) Tìm tất cả các cặp vật phẩm (Item) mà một người chơi (Player) có thể trang bị, trong đó một vật phẩm là Weapon (ví dụ ItemType chứa Sword, Axe, Bow, Staff, Dagger, Wand, Hammer) và vật phẩm kia là Armor hoặc Shield. Hiển thị PlayerName, tên vũ khí, và tên giáp/khiên.");
                        break;
                    case 18:
                        Console.WriteLine("Câu 18:Tìm QuestType có tổng GoldReward cao nhất từ các nhiệm vụ đã Completed. Hiển thị QuestType và tổng GoldReward đó.");
                        break;
                    case 19:
                        Console.WriteLine("Câu 19:Tính Chỉ số Quest Hoàn thành cho mỗi người chơi, sau đó liệt kê 3 người chơi có chỉ số này cao nhất.");
                        break;
                    case 20:
                        Console.WriteLine("Câu 20:Tìm những người chơi (Player) đã được giao ít nhất một nhiệm vụ (Quest) yêu cầu một vật phẩm (RequiredItemID không null) và họ đang sở hữu vật phẩm đó. Hiển thị PlayerName, QuestName, và ItemName của vật phẩm yêu cầu.");
                        break;
                    default:
                        Console.WriteLine("\nThư mục này không có mời bạn chọn lại!!");
                        break;
                }
            }
        }
    }
}
