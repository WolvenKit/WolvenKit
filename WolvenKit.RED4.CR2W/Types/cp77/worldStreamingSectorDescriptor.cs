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
			get
			{
				if (_data == null)
				{
					_data = (raRef<worldStreamingSector>) CR2WTypeManager.Create("raRef:worldStreamingSector", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("streamingBox")] 
		public Box StreamingBox
		{
			get
			{
				if (_streamingBox == null)
				{
					_streamingBox = (Box) CR2WTypeManager.Create("Box", "streamingBox", cr2w, this);
				}
				return _streamingBox;
			}
			set
			{
				if (_streamingBox == value)
				{
					return;
				}
				_streamingBox = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("questPrefabNodeRef")] 
		public NodeRef QuestPrefabNodeRef
		{
			get
			{
				if (_questPrefabNodeRef == null)
				{
					_questPrefabNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "questPrefabNodeRef", cr2w, this);
				}
				return _questPrefabNodeRef;
			}
			set
			{
				if (_questPrefabNodeRef == value)
				{
					return;
				}
				_questPrefabNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("numNodeRanges")] 
		public CUInt32 NumNodeRanges
		{
			get
			{
				if (_numNodeRanges == null)
				{
					_numNodeRanges = (CUInt32) CR2WTypeManager.Create("Uint32", "numNodeRanges", cr2w, this);
				}
				return _numNodeRanges;
			}
			set
			{
				if (_numNodeRanges == value)
				{
					return;
				}
				_numNodeRanges = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("variants")] 
		public CArray<worldStreamingSectorVariant> Variants
		{
			get
			{
				if (_variants == null)
				{
					_variants = (CArray<worldStreamingSectorVariant>) CR2WTypeManager.Create("array:worldStreamingSectorVariant", "variants", cr2w, this);
				}
				return _variants;
			}
			set
			{
				if (_variants == value)
				{
					return;
				}
				_variants = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("sectorIndex")] 
		public CUInt32 SectorIndex
		{
			get
			{
				if (_sectorIndex == null)
				{
					_sectorIndex = (CUInt32) CR2WTypeManager.Create("Uint32", "sectorIndex", cr2w, this);
				}
				return _sectorIndex;
			}
			set
			{
				if (_sectorIndex == value)
				{
					return;
				}
				_sectorIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("level")] 
		public CUInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CUInt32) CR2WTypeManager.Create("Uint32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		public worldStreamingSectorDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
