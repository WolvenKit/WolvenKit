using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloorIkBase : animAnimNode_OnePoseInput
	{
		private CName _requiredAnimEvent;
		private CName _blockAnimEvent;
		private CBool _canBeDisabledDueToFrameRate;
		private CBool _useFixedVersion;
		private CFloat _slopeAngleDamp;
		private animSBehaviorConstraintNodeFloorIKCommonData _common;

		[Ordinal(12)] 
		[RED("requiredAnimEvent")] 
		public CName RequiredAnimEvent
		{
			get
			{
				if (_requiredAnimEvent == null)
				{
					_requiredAnimEvent = (CName) CR2WTypeManager.Create("CName", "requiredAnimEvent", cr2w, this);
				}
				return _requiredAnimEvent;
			}
			set
			{
				if (_requiredAnimEvent == value)
				{
					return;
				}
				_requiredAnimEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("blockAnimEvent")] 
		public CName BlockAnimEvent
		{
			get
			{
				if (_blockAnimEvent == null)
				{
					_blockAnimEvent = (CName) CR2WTypeManager.Create("CName", "blockAnimEvent", cr2w, this);
				}
				return _blockAnimEvent;
			}
			set
			{
				if (_blockAnimEvent == value)
				{
					return;
				}
				_blockAnimEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("canBeDisabledDueToFrameRate")] 
		public CBool CanBeDisabledDueToFrameRate
		{
			get
			{
				if (_canBeDisabledDueToFrameRate == null)
				{
					_canBeDisabledDueToFrameRate = (CBool) CR2WTypeManager.Create("Bool", "canBeDisabledDueToFrameRate", cr2w, this);
				}
				return _canBeDisabledDueToFrameRate;
			}
			set
			{
				if (_canBeDisabledDueToFrameRate == value)
				{
					return;
				}
				_canBeDisabledDueToFrameRate = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("useFixedVersion")] 
		public CBool UseFixedVersion
		{
			get
			{
				if (_useFixedVersion == null)
				{
					_useFixedVersion = (CBool) CR2WTypeManager.Create("Bool", "useFixedVersion", cr2w, this);
				}
				return _useFixedVersion;
			}
			set
			{
				if (_useFixedVersion == value)
				{
					return;
				}
				_useFixedVersion = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("slopeAngleDamp")] 
		public CFloat SlopeAngleDamp
		{
			get
			{
				if (_slopeAngleDamp == null)
				{
					_slopeAngleDamp = (CFloat) CR2WTypeManager.Create("Float", "slopeAngleDamp", cr2w, this);
				}
				return _slopeAngleDamp;
			}
			set
			{
				if (_slopeAngleDamp == value)
				{
					return;
				}
				_slopeAngleDamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("common")] 
		public animSBehaviorConstraintNodeFloorIKCommonData Common
		{
			get
			{
				if (_common == null)
				{
					_common = (animSBehaviorConstraintNodeFloorIKCommonData) CR2WTypeManager.Create("animSBehaviorConstraintNodeFloorIKCommonData", "common", cr2w, this);
				}
				return _common;
			}
			set
			{
				if (_common == value)
				{
					return;
				}
				_common = value;
				PropertySet(this);
			}
		}

		public animAnimNode_FloorIkBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
