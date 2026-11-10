using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using WolvenKit.App.Models.ProjectManagement.Project;
using WolvenKit.Core.Exceptions;
using WolvenKit.Interfaces.Extensions;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Helpers;

public static class InkatlasImageGenerator
{
    /// <summary>
    /// Checks if the target folder exists and contains png files, throws exception if not.
    /// </summary>
    /// <exception cref="InvalidOperationException">
    /// If the folder doesn't contain png files and no placeholders are set
    /// </exception>
    ///
    /// <returns>Path to folder with .png files for inkatlas generation</returns>
    public static string VerifyFolderAndGeneratePlaceholders(string pngFolder, List<string> variants,
        string atlasFileName)
    {
        if (string.IsNullOrEmpty(pngFolder))
        {
            pngFolder = Path.Combine(Path.GetTempPath(), $"{atlasFileName}_icons");
        }

        Directory.CreateDirectory(pngFolder);
        if (variants.Count == 0 && Directory.GetFiles(pngFolder, "*.png").Length == 0)
        {
            throw new InvalidOperationException("No variants provided and no png files found in the target folder.");
        }

        GenerateDummyIcons(pngFolder, "", variants.ToArray());

        if (Directory.GetFiles(pngFolder, "*.png").Length == 0)
        {
            throw new InvalidOperationException("Failed to generate placeholder png files for the provided variants.");
        }

        return pngFolder;
    }

    /// <summary>
    /// Generates an inkatlas from input parameters. Does not generate placeholders, this has to be done in <see cref="VerifyFolderAndGeneratePlaceholders"./>
    /// </summary>
    ///
    /// <returns>A boolean if the write operation to the original path was successful</returns>
    public static bool GenerateAtlas(
        string pngFolder,
        string relativeSourcePath,
        string atlasFileName,
        int tileWidth,
        int tileHeight,
        bool cropIcons,
        Cr2WTools cr2WTools,
        Cp77Project activeProject)
    {
        if (!Directory.Exists(pngFolder)) // shouldn't happen anymore at this point, but better safe than sorry
        {
            return false;
        }

        var parts = CreateAtlasImages(pngFolder, relativeSourcePath, atlasFileName, activeProject, tileWidth,
            tileHeight, cropIcons);

        var inkatlas = CreateInkatlas(relativeSourcePath, atlasFileName, parts);

        var absoluteSourcePath = Path.Combine(activeProject.ModDirectory, relativeSourcePath);

        // Ensure output directory exists
        Directory.CreateDirectory(absoluteSourcePath);
        var destFileName = Path.Combine(absoluteSourcePath, $"{atlasFileName.Replace(".inkatlas", "")}.inkatlas");
        var writtenToOriginalPath = true;

        if (File.Exists(destFileName))
        {
            try
            {
                File.Delete(destFileName);
            }
            catch
            {
                destFileName = destFileName.Replace(".inkatlas", "_new.inkatlas");
                writtenToOriginalPath = false;
            }
        }
        var cr2WFile = new CR2WFile() { RootChunk = inkatlas };
        cr2WTools.WriteCr2W(cr2WFile, destFileName);
        return writtenToOriginalPath;
    }


    public static void GenerateDummyIcons(string folderPath, string prefix, string[] variants)
    {
        // nothing to do
        if (variants.Length == 0)
        {
            return;
        }

        Directory.CreateDirectory(folderPath);

        foreach (var (variant, idx) in variants.Select((v, i) => (v, i)))
        {
            var safeVariant = variant.ToArchiveFileName();

            if (string.IsNullOrWhiteSpace(safeVariant))
            {
                safeVariant = $"icon_{idx}";
            }

            var fileName = Path.Combine(folderPath, $"{prefix}{safeVariant}.png");

            if (File.Exists(fileName))
            {
                continue;
            }

            using var bmp = new Bitmap(160, 160);
            using var g = Graphics.FromImage(bmp);
            using var font = new Font("Arial", 14, FontStyle.Bold);
            using var brush = new SolidBrush(Color.Black);
            using var stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center
            };

            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            g.DrawString(variant, font, brush, new RectangleF(0, 0, bmp.Width, bmp.Height), stringFormat);

            // write to temp file first to avoid A generic error occurred in GDI+
            var tmp = fileName + ".tmp";
            bmp.Save(tmp, ImageFormat.Png);

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

            File.Move(tmp, fileName);
            // bmp.Save(fileName, ImageFormat.Png);
        }
    }

    private static Bitmap RenderToTile(Image source, int tileWidth, int tileHeight, bool cropIcons)
    {
        var srcW = source.Width;
        var srcH = source.Height;

        var scaleX = (double)tileWidth / srcW;
        var scaleY = (double)tileHeight / srcH;

        // contain (no crop) vs cover (crop)
        var scale = cropIcons ? Math.Max(scaleX, scaleY) : Math.Min(scaleX, scaleY);

        var drawW = (int)Math.Round(srcW * scale);
        var drawH = (int)Math.Round(srcH * scale);

        var offsetX = (tileWidth - drawW) / 2;
        var offsetY = (tileHeight - drawH) / 2;

        var tile = new Bitmap(tileWidth, tileHeight);
        using var g = Graphics.FromImage(tile);
        g.Clear(Color.Transparent);
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        g.DrawImage(source, new Rectangle(offsetX, offsetY, drawW, drawH));
        return tile;
    }

    private static List<AtlasPart> CreateAtlasImages(string pngFolder, string relativeSourcePath, string atlasFileName,
        Cp77Project activeProject, int tileWidth, int tileHeight, bool cropIcons)
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
                var sourceWidth = originalImage.Width;
                var sourceHeight = originalImage.Height;

                Bitmap preparedImage;
                int originalWidth;
                int originalHeight;

// If tile size is explicitly provided, generate a fixed-size tile bitmap.
                if (tileWidth > 0 && tileHeight > 0)
                {
                    preparedImage = RenderToTile(originalImage, tileWidth, tileHeight, cropIcons);
                    originalWidth = tileWidth;
                    originalHeight = tileHeight;
                }
                else
                {
                    // Fallback: keep source dimensions, ensure divisible by 2 like before.
                    originalWidth = sourceWidth;
                    originalHeight = sourceHeight;

                    var paddedWidth = originalWidth + (originalWidth % 2);
                    var paddedHeight = originalHeight + (originalHeight % 2);

                    preparedImage = new Bitmap(paddedWidth, paddedHeight);
                    using var g = Graphics.FromImage(preparedImage);
                    g.Clear(Color.Transparent);
                    g.DrawImage(originalImage, 0, 0, originalWidth, originalHeight);
                }

                images.Add(new ImageData(
                    file,
                    preparedImage,
                    Path.GetFileNameWithoutExtension(file).ToArchiveFileName(),
                    originalWidth,
                    originalHeight
                ));
            }
            catch (Exception ex)
            {
                throw new WolvenKitException(0, $"Error loading image {file}: {ex.Message}");
            }
        }

        if (images.Count == 0)
        {
            throw new WolvenKitException(0, $"Failed to load PNG data from a file in {pngFolder}");
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
                if (currentRow.Count > 0)
                {
                    grid.Add(currentRow);
                }
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

        public string Name { get; set; }
        public Rectangle PixelRect { get; init; }
        public RectangleF UvRect { get; init; }
    }

}
