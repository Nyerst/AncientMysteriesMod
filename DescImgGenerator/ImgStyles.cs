﻿namespace DescImgGenerator
{
    public static class ImgStyles
    {
        public const int itemMargin = 8;
        public const int itemPadding = 4;
        public const int itemWidth = 314;
        public const int itemHeight = 140;

        public const int frameMargin = 4;

        public const int canvasMaxWidth = 628;
        public const int canvasMaxHeight = 10240;

        public static Style nameStyle = new Style()
        {
            TextColor = new SKColor(238, 66, 102),
            FontSize = 16,
            LetterSpacing = 1,
        };

        public static Style descStyle = new()
        {
            TextColor = new SKColor(240, 239, 235),
            FontWeight = 300,
            FontSize = 13.8f,
        };

        public static TextPaintOptions paintOptions = new()
        {
            IsAntialias = true,
            LcdRenderText = true,
        };

        public static SKPaint bgFill = new SKPaint()
        {
            Color = new SKColor(24, 26, 27),
        };

        public static SKPaint bgBorder = new SKPaint()
        {
            Color = new SKColor(93, 101, 178),
            StrokeWidth = 2,
            Style = SKPaintStyle.Stroke,
        };
        public static void DrawItemBackground(SKCanvas canvas, SKRect rect)
        {
            canvas.DrawRect(rect, bgFill);
            canvas.DrawRect(rect, bgBorder);
        }
    }
}
