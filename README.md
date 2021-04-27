# tyq
#include<iostream>
#include<string>
#include<ctime>
using namespace std;
int main()
{
string playStr; //玩家输入的选择
int playWin = 0; //玩家赢
int cptWin = 0; //电脑赢
int noWin = 0; //平局
int cpt; //电脑出什么
int sum = 0; //玩了几局
float win = 0; //胜效率
begin:
sum = playWin + cptWin + noWin;
if (sum == 0)
{
sum = 1;
}
if (sum - noWin != 0)
{
win = (float)playWin / (float)(sum - noWin) * 100;
}
else
{
win = 0;
}
cout << "游戏状态:" << endl << endl << " 玩家赢:" << playWin
<< " 电脑赢:" << cptWin
<< " 平局:" << noWin << " 总局数:" << sum << " 胜率:" << win
<< "%" << endl << endl;
cout << "请出拳(1->剪刀 2－>石头 3->布 Q->退出)" << endl;
cin >> playStr;
srand(time(0));
cpt = rand() % 3 + 1;
if (cpt == 1) //电脑出 剪刀
{
cout << "电脑出剪刀" << endl;
if (playStr[0] == &apos;1&apos;)
{
cout << "玩家出剪刀,平局." << endl;
noWin++;
}
else if (playStr[0] == &apos;2&apos;)
{
cout << "玩家出石头,玩家赢." << endl;
playWin++;
}
else
{
cout << "玩家出布,玩家输." << endl;
cptWin++;
}
}
else if (cpt == 2)
{
cout << "电脑出石头" << endl;
if (playStr[0] == &apos;1&apos;)
{
cout << "玩家出剪刀,玩家输." << endl;
cptWin++;
}
else if (playStr[0] == &apos;2&apos;)
{
cout << "玩家出石头,平局." << endl;
noWin++;
}
else
{
cout << "玩家出剪布,玩家赢." << endl;
playWin++;
}
}
else
{
cout << "电脑出布" << endl;
if (playStr[0] == &apos;1&apos;)
{
cout << "玩家出剪刀,玩家赢." << endl;
playWin++;
}
else if (playStr[0] == &apos;2&apos;)
{
cout << "玩家出石头,玩家输." << endl;
cptWin++;
}
else
{
cout << "玩家出布,平局." << endl;
noWin++;
}
}
if (playStr[0] == &apos;q&apos; || playStr[0] == &apos;Q&apos;)
{
return 0;
}
else
{
getchar();
getchar();
system("cls");
goto begin;
}
}

