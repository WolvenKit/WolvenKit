using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using WolvenKit.Common.Model;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.TweakDB;
using WolvenKit.RED4.TweakDB.Helper;

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
                AddCustomRecords();
                OnLoadDB();
            }
        }

        // just for fun...
        private void AddCustomRecords()
        {
            s_tweakDb.Records.Add("Items.trigger_inline3", typeof(gamedataVehicleWheelRole_Record));
            s_tweakDb.Records.Add("weapons.E3_grenade", typeof(gamedataGrenade_Record));
        }

        public bool Exists(TweakDBID key)
        {
            return s_tweakDb.Flats.Exists(key) || s_tweakDb.Records.Exists(key);
        }

        public string GetString(ulong key) => s_stringHelper.GetString(key);

        public IRedType GetFlat(TweakDBID tdb) => s_tweakDb.Flats.GetValue((ulong)tdb);
        public List<TweakDBID> GetQuery(TweakDBID tdb) => s_tweakDb.Queries.GetQuery((ulong)tdb);
        public byte? GetGroupTag(TweakDBID tdb) => s_tweakDb.GroupTags.GetGroupTag((ulong)tdb);

        public Type GetType(TweakDBID tdb)
        {
            var hash = (ulong)tdb;

            var recordType = s_tweakDb.Records.GetRecord(hash);
            if (recordType != null)
            {
                return recordType;
            }

            var flatValue = s_tweakDb.Flats.GetValue(hash);
            if (flatValue != null)
            {
                return flatValue.GetType();
            }

            return null;
        }

        public List<TweakDBID> GetRecords() => s_tweakDb.GetRecords();
        public List<TweakDBID> GetFlats() => s_tweakDb.GetFlats();
        public List<TweakDBID> GetQueries() => s_tweakDb.GetQueries();
        public List<TweakDBID> GetGroupTags() => s_tweakDb.GetGroupTags();

        public gamedataTweakDBRecord GetRecord(TweakDBID tdb) => s_tweakDb.GetFullRecord(tdb);
        public gamedataTweakDBRecord GetRecord(SAsciiString path) => s_tweakDb.GetFullRecord(path.ToString());

        public IRedType GetFlat(SAsciiString path) => s_tweakDb.GetFlatValue(path.ToString());
    }
}
