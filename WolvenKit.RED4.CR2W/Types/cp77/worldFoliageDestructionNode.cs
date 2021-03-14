using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldFoliageDestructionNode : worldCollisionNode
	{
		private CArray<CUInt32> _populationIndex;
		private CUInt64 _foliageResourceHash;
		private CUInt32 _dataVersion;

		[Ordinal(18)] 
		[RED("populationIndex")] 
		public CArray<CUInt32> PopulationIndex
		{
			get
			{
				if (_populationIndex == null)
				{
					_populationIndex = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "populationIndex", cr2w, this);
				}
				return _populationIndex;
			}
			set
			{
				if (_populationIndex == value)
				{
					return;
				}
				_populationIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("foliageResourceHash")] 
		public CUInt64 FoliageResourceHash
		{
			get
			{
				if (_foliageResourceHash == null)
				{
					_foliageResourceHash = (CUInt64) CR2WTypeManager.Create("Uint64", "foliageResourceHash", cr2w, this);
				}
				return _foliageResourceHash;
			}
			set
			{
				if (_foliageResourceHash == value)
				{
					return;
				}
				_foliageResourceHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("dataVersion")] 
		public CUInt32 DataVersion
		{
			get
			{
				if (_dataVersion == null)
				{
					_dataVersion = (CUInt32) CR2WTypeManager.Create("Uint32", "dataVersion", cr2w, this);
				}
				return _dataVersion;
			}
			set
			{
				if (_dataVersion == value)
				{
					return;
				}
				_dataVersion = value;
				PropertySet(this);
			}
		}

		public worldFoliageDestructionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
