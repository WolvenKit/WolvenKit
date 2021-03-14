using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameItemID : CVariable
	{
		private TweakDBID _id;
		private CUInt32 _rngSeed;
		private CUInt16 _uniqueCounter;

		[Ordinal(0)] 
		[RED("id")] 
		public TweakDBID Id
		{
			get
			{
				if (_id == null)
				{
					_id = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "id", cr2w, this);
				}
				return _id;
			}
			set
			{
				if (_id == value)
				{
					return;
				}
				_id = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("rngSeed")] 
		public CUInt32 RngSeed
		{
			get
			{
				if (_rngSeed == null)
				{
					_rngSeed = (CUInt32) CR2WTypeManager.Create("Uint32", "rngSeed", cr2w, this);
				}
				return _rngSeed;
			}
			set
			{
				if (_rngSeed == value)
				{
					return;
				}
				_rngSeed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("uniqueCounter")] 
		public CUInt16 UniqueCounter
		{
			get
			{
				if (_uniqueCounter == null)
				{
					_uniqueCounter = (CUInt16) CR2WTypeManager.Create("Uint16", "uniqueCounter", cr2w, this);
				}
				return _uniqueCounter;
			}
			set
			{
				if (_uniqueCounter == value)
				{
					return;
				}
				_uniqueCounter = value;
				PropertySet(this);
			}
		}

		public gameItemID(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
