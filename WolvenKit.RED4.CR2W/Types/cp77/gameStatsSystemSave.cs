using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsSystemSave : ISerializable
	{
		private CArray<gameStatsSeedKey> _statsObjectsData;
		private CArray<gameStatModifierSave> _statModifiersData;

		[Ordinal(0)] 
		[RED("statsObjectsData")] 
		public CArray<gameStatsSeedKey> StatsObjectsData
		{
			get
			{
				if (_statsObjectsData == null)
				{
					_statsObjectsData = (CArray<gameStatsSeedKey>) CR2WTypeManager.Create("array:gameStatsSeedKey", "statsObjectsData", cr2w, this);
				}
				return _statsObjectsData;
			}
			set
			{
				if (_statsObjectsData == value)
				{
					return;
				}
				_statsObjectsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statModifiersData")] 
		public CArray<gameStatModifierSave> StatModifiersData
		{
			get
			{
				if (_statModifiersData == null)
				{
					_statModifiersData = (CArray<gameStatModifierSave>) CR2WTypeManager.Create("array:gameStatModifierSave", "statModifiersData", cr2w, this);
				}
				return _statModifiersData;
			}
			set
			{
				if (_statModifiersData == value)
				{
					return;
				}
				_statModifiersData = value;
				PropertySet(this);
			}
		}

		public gameStatsSystemSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
