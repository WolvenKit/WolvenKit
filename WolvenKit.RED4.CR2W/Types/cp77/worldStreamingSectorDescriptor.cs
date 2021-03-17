using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorDescriptor : CVariable
	{
		private raRef<worldStreamingSector> _data;
		private Box _streamingBox;
		private NodeRef _questPrefabNodeRef;
		private CUInt32 _numNodeRanges;
		private CArray<worldStreamingSectorVariant> _variants;
		private CUInt32 _sectorIndex;
		private CUInt32 _level;

		[Ordinal(0)] 
		[RED("data")] 
		public raRef<worldStreamingSector> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(1)] 
		[RED("streamingBox")] 
		public Box StreamingBox
		{
			get => GetProperty(ref _streamingBox);
			set => SetProperty(ref _streamingBox, value);
		}

		[Ordinal(2)] 
		[RED("questPrefabNodeRef")] 
		public NodeRef QuestPrefabNodeRef
		{
			get => GetProperty(ref _questPrefabNodeRef);
			set => SetProperty(ref _questPrefabNodeRef, value);
		}

		[Ordinal(3)] 
		[RED("numNodeRanges")] 
		public CUInt32 NumNodeRanges
		{
			get => GetProperty(ref _numNodeRanges);
			set => SetProperty(ref _numNodeRanges, value);
		}

		[Ordinal(4)] 
		[RED("variants")] 
		public CArray<worldStreamingSectorVariant> Variants
		{
			get => GetProperty(ref _variants);
			set => SetProperty(ref _variants, value);
		}

		[Ordinal(5)] 
		[RED("sectorIndex")] 
		public CUInt32 SectorIndex
		{
			get => GetProperty(ref _sectorIndex);
			set => SetProperty(ref _sectorIndex, value);
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		public worldStreamingSectorDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
