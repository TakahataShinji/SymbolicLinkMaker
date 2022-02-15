// - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
//
// PowerShellWrapper
//
// PowerShell操作
//
// - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    class PowerShellWrapper
    {
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // public関数
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // [static]PowerShellを実行
        // -------------------------------------------------------------
        // 引数   | String cmd    : Shellコマンド
        //        | bool   hidden : PowerShellウィンドウを隠すか
        //        |                 true  - 隠す
        //        |                 false - 隠さない(ウィンドウを表示する)
        // -------------------------------------------------------------
        // 戻り値 | なし
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        public static void Exec(String cmd, bool hidden = true)
        {
            // プロセス生成
            Process ps = new Process();
            ps.StartInfo.FileName = "PowerShell.exe";
            ps.StartInfo.WindowStyle = hidden ? ProcessWindowStyle.Hidden : ProcessWindowStyle.Normal;
            ps.StartInfo.Arguments = cmd;

            // プロセス開始
            ps.Start();
        }

        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        // [static]New-Itemコマンド実行
        // -------------------------------------------------------------
        // 引数   | String path     : -Path     オプション引数
        //        | String name     : -Name     オプション引数
        //        | String value    : -Value    オプション引数
        //        | String itemType : -ItemType オプション引数
        //        | bool   hidden   : PowerShellウィンドウを隠すか
        //        |                   true  - 隠す
        //        |                   false - 隠さない(ウィンドウを表示する)
        // -------------------------------------------------------------
        // 戻り値 | なし
        // -------------------------------------------------------------
        // path, name, value の前後にシングルクォートを付与する
        // - = - = - = - = - = - = - = - = - = - = - = - = - = - = - = -
        public static void NewItem(String path     = null, 
                                   String name     = null, 
                                   String value    = null,
                                   String itemType = null, 
                                   bool   hidden   = true)
        {
            String cmd = @"New-Item";

            if (!String.IsNullOrEmpty(path))     cmd += @" -Path '"    + path     + "'";
            if (!String.IsNullOrEmpty(name))     cmd += @" -Name '"    + name     + "'";
            if (!String.IsNullOrEmpty(value))    cmd += @" -Value '"   + value    + "'";
            if (!String.IsNullOrEmpty(itemType)) cmd += @" -ItemType " + itemType      ;

            Exec(cmd, hidden);
        }

    }
}
