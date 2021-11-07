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
    
    #region 野菜_名前
    public static string[] ve_name = {
        "ブロッコリー",
        "ピーマン",
        "きゅうり",
        "きゃべつ",
        "レタス",
        "白菜",
        "トマト",
        "じゃがいも",
        "パプリカ",
        "小松菜",
        "セロリ",
        "スイカ",
        "カブ",
        "ニンジン",
        "ダイコン",
        "サツマイモ",
        "枝豆",
        "そら豆",
        "トウモロコシ",
        "レンコン",
        "カボチャ",
        "メロン",
        "タマネギ"
    };
    #endregion
    #region 野菜_ファイルパス
    public static string[] ve_pass = {
        "images/vegetable/burokkori-",
        "images/vegetable/pi-mnn",
        "images/vegetable/kyu-ri",
        "images/vegetable/kyabetu",
        "images/vegetable/retasu",
        "images/vegetable/hakusai",
        "images/vegetable/tomato",
        "images/vegetable/jagaimo",
        "images/vegetable/papurika",
        "images/vegetable/komatuna",
        "images/vegetable/serori-",
        "images/vegetable/watermelon",
        "images/vegetable/turnip",
        "images/vegetable/carrot",
        "images/vegetable/radish",
        "images/vegetable/sweetpotato",
        "images/vegetable/greensoybeans",
        "images/vegetable/broadbeans",
        "images/vegetable/corn",
        "images/vegetable/lotusroot",
        "images/vegetable/pumpkin",
        "images/vegetable/melon",
        "images/vegetable/onion"
    };
    #endregion
    #region 動物_名前
    public static string[] an_name = {
        "トラ",
        "ライオン",
        "チーター",
        "牛",
        "にわとり",
        "豚",
        "きつね",
        "たぬき",
        "ネズミ",
        "ゾウ",
        "キリン",
        "ウマ",
        "シカ",
        "トナカイ",
        "イルカ",
        "クジラ",
        "クマ",
        "パンダ",
        "ゴリラ",
        "カバ",
        "ヤギ",
        "シャチ",
        "サル"
    };
    #endregion
    #region 動物_ファイルパス
    public static string[] an_pass = {
        "images/animal/tora",
        "images/animal/raionn",
        "images/animal/ti-ta-",
        "images/animal/usi",
        "images/animal/niwatori",
        "images/animal/buta",
        "images/animal/kitune",
        "images/animal/tanuki",
        "images/animal/nezumi",
        "images/animal/elephant",
        "images/animal/giraffe",
        "images/animal/horse",
        "images/animal/deer",
        "images/animal/reindeer",
        "images/animal/dolphin",
        "images/animal/whale",
        "images/animal/bear",
        "images/animal/panda",
        "images/animal/gorilla",
        "images/animal/hippopotamus",
        "images/animal/goat",
        "images/animal/orca",
        "images/animal/monkey"
    };
    #endregion
    #region スポーツ_名前
    public static string[] sp_name = {
        "野球",
        "サッカー",
        "剣道",
        "バレー",
        "バスケ",
        "ラグビー",
        "卓球",
        "テニス",
        "バドミントン",
        "ゴルフ",
        "フェンシング",
        "ビリヤード",
        "アーチェリー",
        "相撲",
        "柔道",
        "ハンドボール",
        "リレー",
        "棒高跳び",
        "水泳",
        "砲丸投げ",
        "ハンマー投げ",
        "ゲートボール",
        "ボクシング"
    };
    #endregion
    #region スポーツ_ファイルパス
    public static string[] sp_pass = {
        "images/sports/yakyuu",
        "images/sports/sakka-",
        "images/sports/kenndou",
        "images/sports/bare-",
        "images/sports/basuke",
        "images/sports/ragubi-",
        "images/sports/takkyuu",
        "images/sports/tenisu",
        "images/sports/batominntonn",
        "images/sports/golf",
        "images/sports/fencing",
        "images/sports/billiards",
        "images/sports/archery",
        "images/sports/sumou",
        "images/sports/jyuudou",
        "images/sports/handball",
        "images/sports/relay",
        "images/sports/boutakatobi",
        "images/sports/swimming",
        "images/sports/hougannnage",
        "images/sports/hannma-nage",
        "images/sports/gateball",
        "images/sports/boxing"
    };
    #endregion


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
    public static int counttt = 0;//準備完了のカウント数3
    //服部
    public static int OnOff = 0;
}
