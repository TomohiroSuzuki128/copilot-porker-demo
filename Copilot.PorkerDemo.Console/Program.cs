// See https://aka.ms/new-console-template for more information

// コンソールをUTF-8で表示する
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Dealer を初期化
Dealer dealer = new Dealer();
// Dealer の CreateDeck メソッドでデッキを作成
dealer.CreateDeck();
// Dealer の ShuffleDeck メソッドでデッキをシャッフル
dealer.ShuffleDeck();

// Player1名を初期化
Player player1 = new Player();

Console.WriteLine("カードを配ります。Enterを押して下さい");
Console.ReadLine();

// Dealer の DealCards メソッドで player1 にカードを配る
dealer.DealCards(new List<Player> { player1 }, 5);

// player1 の手札を表示
player1.ShowHand();

// 保持するカードの番号を入力させてEnterを押してもらう、複数の場合はカンマ区切り
Console.WriteLine("保持するカードの番号を入力して下さい。複数の場合はカンマ区切り");
string input = Console.ReadLine();

// player1 の HoldCards メソッドで保持するカードを決める。引数 input は null にならないようにする
player1.HoldCards(input ?? "");

Console.WriteLine("カードをチェンジします。Enterを押して下さい");
Console.ReadLine();

// player1 の カードをチェンジする
dealer.SwapUnheldCards(new List<Player> { player1 });

// player1 の手札を表示
player1.ShowHand();

// player1 の役を表示
Console.WriteLine(player1.HandRank);






