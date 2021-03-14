using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPoolsSystemSave : ISerializable
	{
		private CArray<gameStatsObjectID> _mapping;
		private CArray<gameStatPoolData> _statPools;

		[Ordinal(0)] 
		[RED("mapping")] 
		public CArray<gameStatsObjectID> Mapping
		{
			get
			{
				if (_mapping == null)
				{
					_mapping = (CArray<gameStatsObjectID>) CR2WTypeManager.Create("array:gameStatsObjectID", "mapping", cr2w, this);
				}
				return _mapping;
			}
			set
			{
				if (_mapping == value)
				{
					return;
				}
				_mapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statPools")] 
		public CArray<gameStatPoolData> StatPools
		{
			get
			{
				if (_statPools == null)
				{
					_statPools = (CArray<gameStatPoolData>) CR2WTypeManager.Create("array:gameStatPoolData", "statPools", cr2w, this);
				}
				return _statPools;
			}
			set
			{
				if (_statPools == value)
				{
					return;
				}
				_statPools = value;
				PropertySet(this);
			}
		}

		public gameStatPoolsSystemSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
