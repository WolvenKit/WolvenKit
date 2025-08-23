using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;
using WolvenKit.Core.Compression;
using WolvenKit.Core.Exceptions;
using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services;

public class CRUIDService
{
    private static CRUIDService? s_Instance;
    
    #region Fields

    private const string s_used = "WolvenKit.Common.Resources.basecruids.kark";

    private volatile bool _isLoaded;
    private List<ulong> _baseCRUIDS = new();
    private List<ulong> _additionalCRUIDS = new();
    
    private readonly Random _random = new();

    public bool IsLoaded => _isLoaded;

    #endregion

    #region Constructors

    public CRUIDService()
    {
        s_Instance = this;
    }

    #endregion Constructors

    #region Private Methods

    private MemoryStream DecompressEmbeddedFile(string resourceName)
    {
        using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName).NotNull();

        // read KARK header
        var oodleCompression = stream.ReadStruct<uint>();
        if (oodleCompression != Oodle.KARK)
        {
            throw new DecompressionException($"Incorrect hash file.");
        }

        var outputsize = stream.ReadStruct<uint>();

        // read the rest of the stream
        var outputbuffer = new byte[outputsize];

        var inbuffer = stream.ToByteArray(true);

        Oodle.Decompress(inbuffer, outputbuffer);

        return new MemoryStream(outputbuffer);
    }

    #endregion

    #region Public Methods

    public static CRUID GenerateRandomCRUID() => s_Instance?.GenerateNewCRUID() ?? new CRUID();

    public void Load()
    {
        _baseCRUIDS = JsonSerializer.Deserialize<List<ulong>>(DecompressEmbeddedFile(s_used)).NotNull();

        var userFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit", "user_cruids.json");
        if (File.Exists(userFile))
        {
            _additionalCRUIDS = JsonSerializer.Deserialize<List<ulong>>(File.ReadAllText(userFile)).NotNull();
        }

        _isLoaded = true;
    }

    public void SaveUserCRUIDS()
    {
        var dataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "REDModding", "WolvenKit");
        Directory.CreateDirectory(dataPath);

        File.WriteAllText(Path.Combine(dataPath, "user_cruids.json"), JsonSerializer.Serialize(_additionalCRUIDS));
    }

    public CRUID GenerateNewCRUID()
    {
        while (true)
        {
            var value = _random.NextCRUID();
            
            if (!_baseCRUIDS.Contains(value) && !_additionalCRUIDS.Contains(value))
            {
                _additionalCRUIDS.Add(value);
                return value;
            }
        }
    }

    #endregion Public Methods
}