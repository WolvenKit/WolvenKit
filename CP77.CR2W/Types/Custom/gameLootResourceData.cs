using System.Collections.Generic;
using System.IO;
using CP77.CR2W.Reflection;

namespace CP77.CR2W.Types
{
    [REDMeta]
	public class gameLootResourceData : gameLootResourceData_
    {
        [REDBuffer(true)] public CArrayCompressed<CookedLootData> Values { get; set; }

        public gameLootResourceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Values = new CArrayCompressed<CookedLootData>(cr2w, this, nameof(Values)) {IsSerialized = true};
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);

            var count = file.ReadVLQInt32();
            for (var i = 0; i < count; i++)
            {
                var data = new CookedLootData(cr2w, this, "data") {IsSerialized = true};
                data.Key.Read(file, 4);
                Values.Add(data);
            }
            foreach (var cookedLootData in Values)
            {
                cookedLootData.Read(file, 0);
            }
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);

            file.WriteVLQInt32(Values.Count);
            foreach (var cookedLootData in Values)
            {
                cookedLootData.Key.Write(file);
            }

            foreach (var cookedLootData in Values)
            {
                cookedLootData.Write(file);
            }
        }
    }

    [REDMeta]
    public class CookedLootData : CVariable
    {
        public CookedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Key = new CUInt64(cr2w, this, nameof(Key)) { IsSerialized = true };
            LootTableIds = new CArrayVLQInt32<TweakDBID>(cr2w, this, nameof(LootTableIds)) { IsSerialized = true };
            ContentAssignment = new TweakDBID(cr2w, this, nameof(ContentAssignment)) { IsSerialized = true };
        }

        [REDBuffer(true)] public CUInt64 Key { get; init; }
        [REDBuffer(true)] public CArrayVLQInt32<TweakDBID> LootTableIds { get; init; }
        [REDBuffer(true)] public TweakDBID ContentAssignment { get; init; }

        public override void Read(BinaryReader file, uint size)
        {
            LootTableIds.Read(file, 0);
            ContentAssignment.Read(file, 8);
        }

        public override void Write(BinaryWriter file)
        {
            LootTableIds.Write(file);
            ContentAssignment.Write(file);
        }
    }
}
