using System.Collections.Generic;
using System.IO;
using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
    [REDMeta]
	public class gameLootResourceData : gameLootResourceData_
    {
        private CArrayCompressed<CookedLootData> _values;

        [REDBuffer(true)]
        public CArrayCompressed<CookedLootData> Values
        {
            get => GetProperty(ref _values);
            set => SetProperty(ref _values, value);
        }

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
        private CUInt64 _key;
        private CArrayVLQInt32<TweakDBID> _lootTableIds;
        private TweakDBID _contentAssignment;

        public CookedLootData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name)
        {
            Key.IsSerialized = true;
            LootTableIds.IsSerialized = true;
            ContentAssignment.IsSerialized = true;
        }

        [REDBuffer(true)]
        public CUInt64 Key
        {
            get => GetProperty(ref _key);
        }

        [REDBuffer(true)]
        public CArrayVLQInt32<TweakDBID> LootTableIds
        {
            get => GetProperty(ref _lootTableIds);
        }

        [REDBuffer(true)]
        public TweakDBID ContentAssignment
        {
            get => GetProperty(ref _contentAssignment);
        }

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
