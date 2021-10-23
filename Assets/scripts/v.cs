using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class v : MonoBehaviour
{
    //加藤君の作った共通変数
    public static int[] panel = new int[3];
    public static int player_count = 2; //回答者数
    public static int ansum = 0;
    public static bool tohome = false;
    public static string theme = "greatman";
    public static int[] choices = new int[3];// = 0;
    public static bool ttf = false;
    public static int answer = 0;


    //岩下が作った共通変数
    public static int all_player = 3;//全体のプレイヤー数
    public static int turn_sum = 0;//ターンの合計
    public static int result_sum = 0;//リザルトボタンを押した人数
    public static int select_sum = 0;//ロールを選択した人の数
    public static int res_sum = 0;//回答者を選択した人数
    public static bool turn_frag = false;
    public static bool result_frag = false;
    public static bool wait_frag = false;//全員待ったかどうか
    public static int correct0 = 0;//0番(1番左)が答えの選択をした人数
    public static int correct1 = 0;//1番(真ん中)が答えの選択をした人数
    public static int correct2 = 0;//2番(1番右)が答えの選択をした人数
    public static bool ep = false; //チーム選択のフラグ

    //追記(9/5)
    public static float ans_time = 5.0f;//答えから次の問題へ行く時間
    public static bool ans_time_flag = false;//answertimeのフラグ(true:5秒経過/false:一問終了)
    //追記(9/14)
    public static bool start_flag = true;//true:ターン開始 false:一問終了後の5秒後の待機時間
    //追記(9/15)
    public static int correct_sum = 0;//全体の正答率
    //追記(9/20)
    public static bool grade_se_fg;//最終結果のse繰り返すよう
    public static float se_timer;

    //追記(10/12)
    public static int QuestionerActorTurn;//アクターナンバーとこいつが一致してるかどうかで出題者が変わる

    //永井が作ったよ
    public static int count = 0;//準備完了のカウント数
    public static int countt = 0;//準備完了のカウント数2
    //服部
    public static int OnOff = 0;
}
