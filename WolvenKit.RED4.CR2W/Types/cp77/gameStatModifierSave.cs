using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierSave : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _statModifierUnions;
		private gameStatsObjectID _statsObjectID;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("statModifierUnions")] 
		public CArray<CHandle<gameStatModifierData>> StatModifierUnions
		{
			get
			{
				if (_statModifierUnions == null)
				{
					_statModifierUnions = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "statModifierUnions", cr2w, this);
				}
				return _statModifierUnions;
			}
			set
			{
				if (_statModifierUnions == value)
				{
					return;
				}
				_statModifierUnions = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("statsObjectID")] 
		public gameStatsObjectID StatsObjectID
		{
			get
			{
				if (_statsObjectID == null)
				{
					_statsObjectID = (gameStatsObjectID) CR2WTypeManager.Create("gameStatsObjectID", "statsObjectID", cr2w, this);
				}
				return _statsObjectID;
			}
			set
			{
				if (_statsObjectID == value)
				{
					return;
				}
				_statsObjectID = value;
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

		public gameStatModifierSave(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
