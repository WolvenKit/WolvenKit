using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldTrafficPersistentData : CVariable
	{
		private CArray<worldTrafficLanePersistent> _lanes;
		private CArray<CArray<CUInt16>> _neighborGroups;

		[Ordinal(0)] 
		[RED("lanes")] 
		public CArray<worldTrafficLanePersistent> Lanes
		{
			get
			{
				if (_lanes == null)
				{
					_lanes = (CArray<worldTrafficLanePersistent>) CR2WTypeManager.Create("array:worldTrafficLanePersistent", "lanes", cr2w, this);
				}
				return _lanes;
			}
			set
			{
				if (_lanes == value)
				{
					return;
				}
				_lanes = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("neighborGroups")] 
		public CArray<CArray<CUInt16>> NeighborGroups
		{
			get
			{
				if (_neighborGroups == null)
				{
					_neighborGroups = (CArray<CArray<CUInt16>>) CR2WTypeManager.Create("array:array:Uint16", "neighborGroups", cr2w, this);
				}
				return _neighborGroups;
			}
			set
			{
				if (_neighborGroups == value)
				{
					return;
				}
				_neighborGroups = value;
				PropertySet(this);
			}
		}

		public worldTrafficPersistentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
