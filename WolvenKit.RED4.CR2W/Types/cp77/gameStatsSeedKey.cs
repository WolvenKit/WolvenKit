using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatsSeedKey : CVariable
	{
		private entEntityID _entityID;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("entityID")] 
		public entEntityID EntityID
		{
			get
			{
				if (_entityID == null)
				{
					_entityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "entityID", cr2w, this);
				}
				return _entityID;
			}
			set
			{
				if (_entityID == value)
				{
					return;
				}
				_entityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		public gameStatsSeedKey(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
