using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using WolvenKit.Common.Model;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Helper;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services
{
    public class TweakDBService : ITweakDBService
    {
        private const string tweakdbstr = "WolvenKit.Common.Resources.tweakdbstr.kark";
        private const string tweakdbstr_add = "WolvenKit.Common.Resources.tweakdbstr_add.kark";

        private static readonly TweakDBStringHelper s_stringHelper = new();
        private static TweakDB s_tweakDb = new();

        public event EventHandler Loaded;

        public TweakDBService()
        {
            s_stringHelper.LoadFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(tweakdbstr));
            s_stringHelper.LoadFromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream(tweakdbstr_add));
            TweakDBID.ResolveHashHandler = s_stringHelper.GetString;
        }

        private void OnLoadDB()
        {
            if (Loaded != null)
            {
                Loaded(this, EventArgs.Empty);
            }
        }

        public void LoadDB(string path)
        {
            using var fh = File.OpenRead(path);
            using var reader = new TweakDBReader(fh);

            if (reader.ReadFile(out var tweakDb) == WolvenKit.RED4.TweakDB.EFileReadErrorCodes.NoError)
            {
                s_tweakDb = tweakDb;
                OnLoadDB();
            }
        }

        public bool Exists(TweakDBID key) => s_tweakDb.Flats.Exists(key) || s_tweakDb.Records.Exists(key);

        public string GetString(ulong key) => s_stringHelper.GetString(key);

        public IRedType GetFlat(TweakDBID tdb) => s_tweakDb.Flats.GetValue((ulong)tdb);

        public Type GetType(TweakDBID tdb)
        {
            var hash = (ulong)tdb;

            var recordType = s_tweakDb.Records.GetRecord(hash);
            if (recordType != null)
            {
                return recordType;
            }

            var flatValue = s_tweakDb.Flats.GetValue(hash);
            return flatValue?.GetType();
        }

        public List<TweakDBID> GetRecords() => s_tweakDb.GetRecords();

        public gamedataTweakDBRecord GetRecord(TweakDBID tdb) => s_tweakDb.GetFullRecord(tdb.GetResolvedText());
        public gamedataTweakDBRecord GetRecord(SAsciiString path) => s_tweakDb.GetFullRecord(path.ToString());

        public IRedType GetFlat(SAsciiString path) => s_tweakDb.GetFlatValue(path.ToString());
    }
}
