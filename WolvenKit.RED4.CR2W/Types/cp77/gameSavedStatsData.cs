using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSavedStatsData : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _statModifiers;
		private CArray<CEnum<gamedataStatType>> _inactiveStats;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("statModifiers")] 
		public CArray<CHandle<gameStatModifierData>> StatModifiers
		{
			get
			{
				if (_statModifiers == null)
				{
					_statModifiers = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "statModifiers", cr2w, this);
				}
				return _statModifiers;
			}
			set
			{
				if (_statModifiers == value)
				{
					return;
				}
				_statModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("inactiveStats")] 
		public CArray<CEnum<gamedataStatType>> InactiveStats
		{
			get
			{
				if (_inactiveStats == null)
				{
					_inactiveStats = (CArray<CEnum<gamedataStatType>>) CR2WTypeManager.Create("array:gamedataStatType", "inactiveStats", cr2w, this);
				}
				return _inactiveStats;
			}
			set
			{
				if (_inactiveStats == value)
				{
					return;
				}
				_inactiveStats = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get
			{
				if (_recordID == null)
				{
					_recordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "recordID", cr2w, this);
				}
				return _recordID;
			}
			set
			{
				if (_recordID == value)
				{
					return;
				}
				_recordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get
			{
				if (_seed == null)
				{
					_seed = (CUInt32) CR2WTypeManager.Create("Uint32", "seed", cr2w, this);
				}
				return _seed;
			}
			set
			{
				if (_seed == value)
				{
					return;
				}
				_seed = value;
				PropertySet(this);
			}
		}

		public gameSavedStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
