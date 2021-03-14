using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionUnequipItemState : gameActionReplicatedState
	{
		private TweakDBID _slotId;
		private CName _animFeatureNameRight;
		private CName _animFeatureNameLeft;
		private CFloat _duration;

		[Ordinal(5)] 
		[RED("slotId")] 
		public TweakDBID SlotId
		{
			get
			{
				if (_slotId == null)
				{
					_slotId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "slotId", cr2w, this);
				}
				return _slotId;
			}
			set
			{
				if (_slotId == value)
				{
					return;
				}
				_slotId = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("animFeatureNameRight")] 
		public CName AnimFeatureNameRight
		{
			get
			{
				if (_animFeatureNameRight == null)
				{
					_animFeatureNameRight = (CName) CR2WTypeManager.Create("CName", "animFeatureNameRight", cr2w, this);
				}
				return _animFeatureNameRight;
			}
			set
			{
				if (_animFeatureNameRight == value)
				{
					return;
				}
				_animFeatureNameRight = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("animFeatureNameLeft")] 
		public CName AnimFeatureNameLeft
		{
			get
			{
				if (_animFeatureNameLeft == null)
				{
					_animFeatureNameLeft = (CName) CR2WTypeManager.Create("CName", "animFeatureNameLeft", cr2w, this);
				}
				return _animFeatureNameLeft;
			}
			set
			{
				if (_animFeatureNameLeft == value)
				{
					return;
				}
				_animFeatureNameLeft = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		public gameActionUnequipItemState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
