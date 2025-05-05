using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class InkatlasImageGenerator
{
    public static void GenerateAtlas(
        string pngFolder,
        string relativeSourcePath,
        string atlasFileName,
        int tileWidth,
        int tileHeight,
        Cr2WTools cr2WTools,
        Cp77Project activeProject)
    {
        var parts = CreateAtlasImages(pngFolder, relativeSourcePath, atlasFileName, activeProject, tileWidth,
            tileHeight);

        var inkatlas = CreateInkatlas(relativeSourcePath, atlasFileName, parts);

        var absoluteSourcePath = Path.Combine(activeProject.ModDirectory, relativeSourcePath);

        // Ensure output directory exists
        Directory.CreateDirectory(absoluteSourcePath);

        var cr2WFile = new CR2WFile() { RootChunk = inkatlas };
        cr2WTools.WriteCr2W(cr2WFile, Path.Combine(absoluteSourcePath, $"{atlasFileName}.inkatlas"));
    }


    private static List<AtlasPart> CreateAtlasImages(string pngFolder, string relativeSourcePath, string atlasFileName,
        Cp77Project activeProject, int tileWidth, int tileHeight)
    {
        // Get all PNG files from source folder
        var pngFiles = Directory.GetFiles(pngFolder, "*.png");
        if (pngFiles.Length == 0)
        {
            throw new InvalidOperationException("The source folder does not contain any PNG files.");
        }

        // Load all images with padding if needed
        var images = new List<ImageData>();
        foreach (var file in pngFiles.OrderByDescending(x => x))
        {
            try
            {
                using var originalImage = Image.FromFile(file);
                var originalWidth = originalImage.Width;
                var originalHeight = originalImage.Height;

                // Apply scaling if tile dimensions are specified
                if (tileWidth > 0 || tileHeight > 0)
                {
                    var (scaledWidth, scaledHeight) = CalculateScaledDimensions(
                        originalWidth,
                        originalHeight,
                        tileWidth,
                        tileHeight
                    );

                    using var scaledImage = new Bitmap(scaledWidth, scaledHeight);
                    using (var g = Graphics.FromImage(scaledImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalImage, 0, 0, scaledWidth, scaledHeight);
                    }

                    originalWidth = scaledWidth;
                    originalHeight = scaledHeight;
                }

                // Ensure image dimensions are divisible by 2
                var paddedWidth = originalWidth + (originalWidth % 2);
                var paddedHeight = originalHeight + (originalHeight % 2);

                var paddedImage = new Bitmap(paddedWidth, paddedHeight);
                using (var g = Graphics.FromImage(paddedImage))
                {
                    g.Clear(Color.Transparent);
                    g.DrawImage(originalImage, 0, 0, originalWidth, originalHeight);
                }

                images.Add(new ImageData
                (
                    file,
                    paddedImage,
                    Path.GetFileNameWithoutExtension(file),
                    originalWidth,
                    originalHeight
                ));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image {file}: {ex.Message}");
            }
        }

        if (images.Count == 0)
        {
            throw new InvalidOperationException("No valid PNG files could be loaded.");
        }

        // Calculate atlas dimensions
        const int maxWidth = 2048;
        var grid = CreateImageGrid(images, maxWidth);
        var (totalWidth, totalHeight) = CalculateAtlasDimensions(grid);

        // Ensure total dimensions are divisible by 2
        totalWidth += totalWidth % 2;
        totalHeight += totalHeight % 2;

        // Paste images and collect part data
        var parts = new List<AtlasPart>();

        // Create combined image
        using var combinedImage = new Bitmap(totalWidth, totalHeight);
        using var graphics = Graphics.FromImage(combinedImage);

        graphics.Clear(Color.Transparent);

        var currentY = 0;

        foreach (var row in grid)
        {
            var maxHeightInRow = row.Max(img => img.Image.Height);
            var currentX = 0;

            foreach (var imageData in row)
            {
                var img = imageData.Image;
                var width = img.Width;
                var height = img.Height;

                // Center vertically in row (accounting for padding)
                var topPixel = currentY + ((maxHeightInRow - height) / 2);
                var leftPixel = currentX;

                graphics.DrawImage(img, leftPixel, topPixel, width, height);

                // Add part data using original dimensions (not padded)
                parts.Add(new AtlasPart(imageData.Name)
                {
                    PixelRect = new Rectangle(
                        leftPixel,
                        topPixel,
                        imageData.OriginalWidth,
                        imageData.OriginalHeight),
                    UvRect = new RectangleF(
                        (float)leftPixel / totalWidth,
                        (float)topPixel / totalHeight,
                        (float)imageData.OriginalWidth / totalWidth,
                        (float)imageData.OriginalHeight / totalHeight)
                });

                currentX += width;
            }

            currentY += maxHeightInRow;
        }

        var absoluteRawPath = Path.Combine(activeProject.RawDirectory, relativeSourcePath);

        // Ensure output directory exists
        Directory.CreateDirectory(absoluteRawPath);

        // Save the combined image
        var outputImagePath = Path.Combine(absoluteRawPath, $"{atlasFileName}.png");
        combinedImage.Save(outputImagePath, System.Drawing.Imaging.ImageFormat.Png);

        // Save the 1080 version (half size)
        var outputImagePath1080 = Path.Combine(absoluteRawPath, $"{atlasFileName}_1080.png");

        // Ensure image dimensions are divisible by 2
        var paddedHalfWidth = (totalWidth / 2) + ((totalWidth / 2) % 2);
        var paddedHalfHeight = (totalHeight / 2) + ((totalHeight / 2) % 2);

        using (var resizedImage = new Bitmap(combinedImage, new Size(paddedHalfWidth, paddedHalfHeight)))
        {
            resizedImage.Save(outputImagePath1080, System.Drawing.Imaging.ImageFormat.Png);
        }

        // Clean up loaded images
        foreach (var imgData in images)
        {
            imgData.Image.Dispose();
        }

        return parts;
    }

    private static (int width, int height) CalculateScaledDimensions(int originalWidth, int originalHeight,
        int maxTileWidth, int maxTileHeight)
    {
        // If both dimensions are specified, scale to fit within while preserving aspect ratio
        if (maxTileWidth > 0 && maxTileHeight > 0)
        {
            var widthRatio = (double)maxTileWidth / originalWidth;
            var heightRatio = (double)maxTileHeight / originalHeight;
            var scaleRatio = Math.Min(widthRatio, heightRatio);

            return (
                (int)Math.Round(originalWidth * scaleRatio),
                (int)Math.Round(originalHeight * scaleRatio)
            );
        }
        // If only width is specified
        else if (maxTileWidth > 0)
        {
            var scale = (double)maxTileWidth / originalWidth;
            return (
                maxTileWidth,
                (int)Math.Round(originalHeight * scale)
            );
        }
        // If only height is specified
        else if (maxTileHeight > 0)
        {
            var scale = (double)maxTileHeight / originalHeight;
            return (
                (int)Math.Round(originalWidth * scale),
                maxTileHeight
            );
        }

        // No scaling needed
        return (originalWidth, originalHeight);
    }

    private static List<List<ImageData>> CreateImageGrid(List<ImageData> images, int maxWidth)
    {
        var grid = new List<List<ImageData>>();
        var currentRow = new List<ImageData>();
        var currentWidth = 0;

        foreach (var imageData in images.OrderByDescending(img => img.Image.Height))
        {
            var width = imageData.Image.Width;

            if (currentWidth + width <= maxWidth)
            {
                currentRow.Add(imageData);
                currentWidth += width;
            }
            else
            {
                grid.Add(currentRow);
                currentRow = [imageData];
                currentWidth = width;
            }
        }

        if (currentRow.Count > 0)
        {
            grid.Add(currentRow);
        }

        return grid;
    }

    private static (int width, int height) CalculateAtlasDimensions(List<List<ImageData>> grid)
    {
        var totalWidth = grid.Max(row => row.Sum(img => img.Image.Width));
        var totalHeight = grid.Sum(row => row.Max(img => img.Image.Height));

        return (totalWidth, totalHeight);
    }

    private static inkTextureAtlas CreateInkatlas(string relativePath, string atlasFileName, List<AtlasPart> parts)
    {
        var atlasXbm = Path.Combine(relativePath, $"{atlasFileName}.xbm");
        var atlasXbm1080 = Path.Combine(relativePath, $"{atlasFileName}_1080.xbm");

        // Create atlas parts
        var atlasParts = new CArray<inkTextureAtlasMapper>();
        foreach (var part in parts)
        {
            atlasParts.Add(new inkTextureAtlasMapper
            {
                ClippingRectInPixels =
                    new Rect
                    {
                        Bottom = part.PixelRect.Bottom,
                        Left = part.PixelRect.Left,
                        Right = part.PixelRect.Right,
                        Top = part.PixelRect.Top
                    },
                ClippingRectInUVCoords = new RectF
                {
                    Bottom = part.UvRect.Bottom,
                    Left = part.UvRect.Left,
                    Right = part.UvRect.Right,
                    Top = part.UvRect.Top
                },
                PartName = part.Name
            });
        }

        // Create texture slots
        var inkatlas = new inkTextureAtlas
        {
            ActiveTexture = Enums.inkTextureType.StaticTexture,
            IsSingleTextureMode = true,
            TextureResolution = Enums.inkETextureResolution.UltraHD_3840_2160
        };

        inkatlas.Slots[0].Texture =
            new CResourceAsyncReference<CBitmapTexture>(atlasXbm, InternalEnums.EImportFlags.Soft);
        inkatlas.Slots[0].Parts = atlasParts;

        inkatlas.Slots[1].Texture =
            new CResourceAsyncReference<CBitmapTexture>(atlasXbm1080, InternalEnums.EImportFlags.Soft);
        inkatlas.Slots[0].Parts = atlasParts;

        return inkatlas;
    }

    private class ImageData
    {
        public ImageData(string path, Bitmap image, string name, int originalWidth, int originalHeight)
        {
            Path = path;
            Image = image;
            Name = name;
            OriginalWidth = originalWidth;
            OriginalHeight = originalHeight;
        }

        public string Path { get; set; }
        public Bitmap Image { get; init; }
        public string Name { get; init; }
        public int OriginalWidth { get; init; }
        public int OriginalHeight { get; init; }
    }

    private class AtlasPart
    {
        public AtlasPart(string name) => Name = name;

        public string Name { get; init; }
        public Rectangle PixelRect { get; init; }
        public RectangleF UvRect { get; init; }
    }
}