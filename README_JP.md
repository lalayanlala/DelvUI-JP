# DelvUI JP

DelvUI JP は、FINAL FANTASY XIV の Dalamud 向け HUD カスタマイズプラグインです。
[DelvUI](https://github.com/DelvUI/DelvUI) を基盤に、日本語の設定 UI とコマンド案内を追加しています。

## 主な機能

- プレイヤー、ターゲット、フォーカスターゲットのユニットフレーム
- パーティフレーム、敵対リスト、ネームプレート
- 全ジョブ向けのジョブ専用 HUD
- キャストバー、GCD、MP ティック、リミットブレイク、経験値バー
- ステータス効果、パーティリキャスト、マウスオーバー操作
- プロファイルの作成、切り替え、インポート／エクスポート
- 位置、サイズ、色、フォント、テクスチャ、表示条件の詳細設定

## 導入（開発版プラグイン）

1. XIVLauncher / Dalamud の設定で「開発者向けプラグイン」を開きます。
2. `DelvUIJP.dll` を選択して読み込みます。
3. ゲーム内で `/delvuijp` または `/duijp` を実行して設定画面を開きます。

ビルド済み DLL は `DelvUI/bin/x64/Release/DelvUIJP.dll`、配布用 ZIP は
`DelvUI/bin/x64/Release/DelvUIJP/latest.zip` に生成されます。

## コマンド

- `/delvuijp` — 設定画面を開く
- `/delvuijp toggle` — HUD の表示／非表示を切り替える
- `/delvuijp show` / `/delvuijp hide` — HUD を表示／非表示にする
- `/delvuijp toggledefaulthud` — ゲーム標準のジョブ HUD を切り替える
- `/delvuijp forcejob <JOB>` — 指定ジョブの HUD をプレビューする
- `/delvuijp profile <名前>` — プロファイルを切り替える
- `/delvuijp mouse <on/off>` — 特殊マウス入力を切り替える

## ビルド

.NET 10 SDK と Dalamud 開発環境が必要です。

```powershell
dotnet build DelvUI.sln -c Release
```

## ライセンスと帰属

本プロジェクトは DelvUI の派生物であり、元プロジェクトと同じ
GNU Affero General Public License v3.0（AGPL-3.0）で提供されます。
著作権表示と `LICENSE` を保持してください。

DelvUI および DelvUI JP は非公式のサードパーティ製プラグインです。
