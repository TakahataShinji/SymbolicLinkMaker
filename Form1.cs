// - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
//
// Form1
//
// アプリケーションのメインフォーム
//
// - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace SymbolicLinkMaker
{
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    // コンストラクタ
    // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // private メソッド(イベントハンドラ)
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // フォームロード時の処理
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // フォームクローズ直後の処理
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // ボタン「>>」(参照先)クリック時の処理
        // 参照先オブジェクト(フォルダまたはファイル)を選択する
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Button_Browse_Linkee_Click(object sender, EventArgs e)
        {
            // ラジオボタン「フォルダ」が選択されている場合
            if (RadioButton_Folder.Checked)
            {
                // 参照先フォルダの選択
                ChooseFolder(TextBox_Linkee);
            }
            // ラジオボタン「ファイル」が選択されている場合
            else if (RadioButton_File.Checked)
            {
                // 参照先ファイルの選択
                ChooseFile(TextBox_Linkee);
            }
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // ボタン「>>」(作成先)クリック時の処理
        // リンクの作成先フォルダを選択する
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Button_Browse_Location_Click(object sender, EventArgs e)
        {
            // 作成先フォルダの選択
            ChooseFolder(TextBox_Location);
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // ボタン「作成」クリック時の処理
        // シンボリックリンクを作成する
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Button_Execute_Click(object sender, EventArgs e)
        {
            // コントロールからパラメータを取得
            // "\" を "/" に置換する
            String linkee   = TextBox_Linkee.Text.Replace(@"\", @"/");      //< 参照先
            String location = TextBox_Location.Text.Replace(@"\", @"/");    //< 作成先
            String linkName = TextBox_LinkName.Text.Replace(@"\", @"/");    //< リンク名

            try
            {
                // 参照先が存在しない場合は例外
                if (!FileOperate.FileExists(linkee))
                {
                    if (!FileOperate.DirectoryExists(linkee))
                    {
                        throw new Exception("参照先が不正、または存在しません。");
                    }
                }

                // 作成先フォルダが存在しない場合は例外
                if (!FileOperate.DirectoryExists(location))
                {
                    throw new Exception("作成先フォルダが不正、または存在しません。");
                }

                // リンク名が空の場合は例外
                if (string.IsNullOrEmpty(linkName))
                {
                    throw new Exception("リンク名が指定されていません。");
                }

                // すでに同名のファイルまたはフォルダが存在する場合は例外
                if (FileOperate.FileExists(location + @"\" + linkName) ||
                    FileOperate.DirectoryExists(location + @"\" + linkName))
                {
                    throw new Exception("同名のファイルまたはフォルダが存在します。");
                }

                // 実行前確認
                // 「いいえ」が押された場合は抜ける
                String msg = $"{linkee}\n" +
                             $"を指すシンボリックリンク\n" +
                             $"{location}/{linkName}\n" +
                             $"を作成します。よろしいですか？";
                if (MessageBoxFunc.ShowYesNoMsgBox(msg) == MessageBoxFunc.E_MsgBoxResult.E_MSGBOX_NO)
                {
                    return;
                }

                // New-Itemコマンド実行
                // 作成対象 : SymbolicLink
                PowerShellWrapper.NewItem(location, linkName, linkee, "SymbolicLink");

                // 終了表示
                MessageBoxFunc.ShowInfoMsgBox("シンボリックリンクを作成しました。");
            }

            // 例外発生時はエラー表示
            catch (Exception ex)
            {
                MessageBoxFunc.ShowErrorMsgBox(ex.Message);
            }

        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // ボタン「終了」クリック時の処理
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            // 終了確認
            // 「はい」が押された場合のみ終了する
            if (MessageBoxFunc.ShowYesNoMsgBox("終了しますか？") == MessageBoxFunc.E_MsgBoxResult.E_MSGBOX_YES)
            {
                // フォームを閉じる
                Close();
            }
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // private メソッド
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // フォルダを選択し、テキストボックスに反映する
        // -------+-----------------------------------------------------
        // 引数   | TextBox tb : [I/O]初期フォルダ取得元 / 反映先テキストボックス
        // -------+-----------------------------------------------------
        // 戻り値 | なし
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void ChooseFolder(TextBox tb)
        {
            String path = tb.Text;      //< 初期パス / 選択されたパス

            // フォルダ選択( path を更新)
            FileOperate.ShowFolderBrowserDialog(ref path);

            // テキストボックスに選択されたフォルダを反映
            tb.Text = path;
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // ファイルを選択し、テキストボックスに反映する
        // -------+-----------------------------------------------------
        // 引数   | TextBox tb : [I/O]初期ファイル取得元 / 反映先テキストボックス
        // -------+-----------------------------------------------------
        // 戻り値 | なし
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        private void ChooseFile(TextBox tb)
        {
            String path = tb.Text;      //< 初期パス / 選択されたパス

            // フォルダ選択( path を更新)
            FileOperate.ShowOpenFileDialog(ref path);

            // テキストボックスに選択されたフォルダを反映
            tb.Text = path;
        }

    }

}
