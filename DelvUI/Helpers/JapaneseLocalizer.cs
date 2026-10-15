using System.Collections.Generic;

namespace DelvUI.Helpers
{
    /// <summary>
    /// Japanese labels for the configuration UI. Keys intentionally remain the
    /// upstream English strings so profiles and configuration paths stay compatible.
    /// </summary>
    public static class JapaneseLocalizer
    {
        private static readonly Dictionary<string, string> Strings = new()
        {
            ["General"] = "一般", ["Customization"] = "カスタマイズ", ["Profiles"] = "プロファイル",
            ["Import"] = "インポート", ["Export"] = "エクスポート", ["Reset"] = "リセット",
            ["Player Unit Frame"] = "プレイヤー・ユニットフレーム", ["Target Unit Frame"] = "ターゲット・ユニットフレーム",
            ["Target of Target Unit Frame"] = "ターゲットのターゲット", ["Focus Target Unit Frame"] = "フォーカスターゲット",
            ["Party Frames"] = "パーティリスト", ["Party Cooldowns"] = "パーティ・リキャスト",
            ["Enemy List"] = "敵対リスト", ["Nameplates"] = "ネームプレート", ["Status Effects"] = "ステータス効果",
            ["Job Specific Bars"] = "ジョブ専用バー", ["Castbar"] = "キャストバー", ["Fonts"] = "フォント",
            ["Bar Textures"] = "バーテクスチャ", ["Global Colors"] = "共通カラー", ["Grid"] = "グリッド",
            ["Enabled"] = "有効", ["Preview"] = "プレビュー", ["Position"] = "位置", ["Size"] = "サイズ",
            ["Width"] = "幅", ["Height"] = "高さ", ["Padding"] = "余白", ["Spacing"] = "間隔",
            ["Anchor"] = "基準位置", ["Color"] = "色", ["Background Color"] = "背景色", ["Border Color"] = "枠線の色",
            ["Show Border"] = "枠線を表示", ["Show Icon"] = "アイコンを表示", ["Show Label"] = "ラベルを表示",
            ["Label"] = "ラベル", ["Text"] = "テキスト", ["Font and Size"] = "フォントとサイズ",
            ["Bar Texture"] = "バーテクスチャ", ["Opacity"] = "不透明度", ["Thickness"] = "太さ",
            ["Hide"] = "非表示", ["Show"] = "表示", ["Always"] = "常に", ["Never"] = "しない",
            ["Left"] = "左", ["Right"] = "右", ["Top"] = "上", ["Bottom"] = "下", ["Center"] = "中央",
            ["TopLeft"] = "左上", ["TopRight"] = "右上", ["BottomLeft"] = "左下", ["BottomRight"] = "右下",
            ["Horizontal"] = "横", ["Vertical"] = "縦", ["Rows"] = "行", ["Columns"] = "列",
            ["Health"] = "HP", ["Mana"] = "MP", ["Shield"] = "バリア", ["Experience"] = "経験値",
            ["Player"] = "プレイヤー", ["Target"] = "ターゲット", ["Focus Target"] = "フォーカスターゲット",
            ["Mouseover"] = "マウスオーバー", ["Role"] = "ロール", ["Job"] = "ジョブ",
            ["Tank"] = "TANK", ["Healer"] = "HEALER", ["Melee DPS"] = "近接DPS", ["Ranged DPS"] = "遠隔DPS",
            ["Close"] = "閉じる", ["Unlock HUD"] = "HUDの固定を解除", ["Lock HUD"] = "HUDを固定",
            ["Hide HUD"] = "HUDを非表示", ["Show HUD"] = "HUDを表示", ["Changelog"] = "更新履歴",
            ["Active Profile"] = "使用中のプロファイル", ["Profile Name"] = "プロファイル名",
            ["Create a new profile:"] = "新しいプロファイルを作成:", ["Copy"] = "コピー", ["Cancel"] = "キャンセル",
            ["Select All"] = "すべて選択", ["Deselect All"] = "すべて解除", ["OK"] = "OK",
            ["Auto-Switch For Specific Jobs"] = "ジョブ別に自動切り替え", ["Attach HUD Layout to this profile"] = "HUDレイアウトをこのプロファイルに関連付ける",
            ["Stretch"] = "引き伸ばし", ["Repeat Horizontal"] = "横に繰り返す", ["Repeat Vertical"] = "縦に繰り返す", ["Repeat"] = "繰り返す"
        };

        public static string Translate(string text) => Strings.TryGetValue(text, out string? value) ? value : text;

        // Keep a stable ImGui ID even when the visible label is translated.
        public static string Label(string text) => $"{Translate(text)}##jp_{text}";
    }
}
