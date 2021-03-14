using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffectReplicatedInfo : CVariable
	{
		private TweakDBID _statusEffectRecordID;
		private CUInt32 _stackCount;
		private CName _source;

		[Ordinal(0)] 
		[RED("statusEffectRecordID")] 
		public TweakDBID StatusEffectRecordID
		{
			get
			{
				if (_statusEffectRecordID == null)
				{
					_statusEffectRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "statusEffectRecordID", cr2w, this);
				}
				return _statusEffectRecordID;
			}
			set
			{
				if (_statusEffectRecordID == value)
				{
					return;
				}
				_statusEffectRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("stackCount")] 
		public CUInt32 StackCount
		{
			get
			{
				if (_stackCount == null)
				{
					_stackCount = (CUInt32) CR2WTypeManager.Create("Uint32", "stackCount", cr2w, this);
				}
				return _stackCount;
			}
			set
			{
				if (_stackCount == value)
				{
					return;
				}
				_stackCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("source")] 
		public CName Source
		{
			get
			{
				if (_source == null)
				{
					_source = (CName) CR2WTypeManager.Create("CName", "source", cr2w, this);
				}
				return _source;
			}
			set
			{
				if (_source == value)
				{
					return;
				}
				_source = value;
				PropertySet(this);
			}
		}

		public gameStatusEffectReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
