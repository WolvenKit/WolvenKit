using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarriedObjectEvents : OldUpperBodyEventsTransition
	{
		private CHandle<AnimFeature_Mounting> _animFeature;
		private CHandle<AnimFeature_Carry> _animCarryFeature;
		private CHandle<AnimFeature_LeftHandAnimation> _leftHandFeature;
		private CHandle<entAnimWrapperWeightSetter> _animWrapperWeightSetterStrong;
		private CHandle<entAnimWrapperWeightSetter> _animWrapperWeightSetterFriendly;
		private CName _styleName;
		private CName _forceStyleName;
		private CBool _isFriendlyCarry;
		private CEnum<gamePSMBodyCarryingStyle> _forcedCarryStyle;

		[Ordinal(0)] 
		[RED("animFeature")] 
		public CHandle<AnimFeature_Mounting> AnimFeature
		{
			get
			{
				if (_animFeature == null)
				{
					_animFeature = (CHandle<AnimFeature_Mounting>) CR2WTypeManager.Create("handle:AnimFeature_Mounting", "animFeature", cr2w, this);
				}
				return _animFeature;
			}
			set
			{
				if (_animFeature == value)
				{
					return;
				}
				_animFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("animCarryFeature")] 
		public CHandle<AnimFeature_Carry> AnimCarryFeature
		{
			get
			{
				if (_animCarryFeature == null)
				{
					_animCarryFeature = (CHandle<AnimFeature_Carry>) CR2WTypeManager.Create("handle:AnimFeature_Carry", "animCarryFeature", cr2w, this);
				}
				return _animCarryFeature;
			}
			set
			{
				if (_animCarryFeature == value)
				{
					return;
				}
				_animCarryFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("leftHandFeature")] 
		public CHandle<AnimFeature_LeftHandAnimation> LeftHandFeature
		{
			get
			{
				if (_leftHandFeature == null)
				{
					_leftHandFeature = (CHandle<AnimFeature_LeftHandAnimation>) CR2WTypeManager.Create("handle:AnimFeature_LeftHandAnimation", "leftHandFeature", cr2w, this);
				}
				return _leftHandFeature;
			}
			set
			{
				if (_leftHandFeature == value)
				{
					return;
				}
				_leftHandFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("AnimWrapperWeightSetterStrong")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterStrong
		{
			get
			{
				if (_animWrapperWeightSetterStrong == null)
				{
					_animWrapperWeightSetterStrong = (CHandle<entAnimWrapperWeightSetter>) CR2WTypeManager.Create("handle:entAnimWrapperWeightSetter", "AnimWrapperWeightSetterStrong", cr2w, this);
				}
				return _animWrapperWeightSetterStrong;
			}
			set
			{
				if (_animWrapperWeightSetterStrong == value)
				{
					return;
				}
				_animWrapperWeightSetterStrong = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("AnimWrapperWeightSetterFriendly")] 
		public CHandle<entAnimWrapperWeightSetter> AnimWrapperWeightSetterFriendly
		{
			get
			{
				if (_animWrapperWeightSetterFriendly == null)
				{
					_animWrapperWeightSetterFriendly = (CHandle<entAnimWrapperWeightSetter>) CR2WTypeManager.Create("handle:entAnimWrapperWeightSetter", "AnimWrapperWeightSetterFriendly", cr2w, this);
				}
				return _animWrapperWeightSetterFriendly;
			}
			set
			{
				if (_animWrapperWeightSetterFriendly == value)
				{
					return;
				}
				_animWrapperWeightSetterFriendly = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("styleName")] 
		public CName StyleName
		{
			get
			{
				if (_styleName == null)
				{
					_styleName = (CName) CR2WTypeManager.Create("CName", "styleName", cr2w, this);
				}
				return _styleName;
			}
			set
			{
				if (_styleName == value)
				{
					return;
				}
				_styleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forceStyleName")] 
		public CName ForceStyleName
		{
			get
			{
				if (_forceStyleName == null)
				{
					_forceStyleName = (CName) CR2WTypeManager.Create("CName", "forceStyleName", cr2w, this);
				}
				return _forceStyleName;
			}
			set
			{
				if (_forceStyleName == value)
				{
					return;
				}
				_forceStyleName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("isFriendlyCarry")] 
		public CBool IsFriendlyCarry
		{
			get
			{
				if (_isFriendlyCarry == null)
				{
					_isFriendlyCarry = (CBool) CR2WTypeManager.Create("Bool", "isFriendlyCarry", cr2w, this);
				}
				return _isFriendlyCarry;
			}
			set
			{
				if (_isFriendlyCarry == value)
				{
					return;
				}
				_isFriendlyCarry = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("forcedCarryStyle")] 
		public CEnum<gamePSMBodyCarryingStyle> ForcedCarryStyle
		{
			get
			{
				if (_forcedCarryStyle == null)
				{
					_forcedCarryStyle = (CEnum<gamePSMBodyCarryingStyle>) CR2WTypeManager.Create("gamePSMBodyCarryingStyle", "forcedCarryStyle", cr2w, this);
				}
				return _forcedCarryStyle;
			}
			set
			{
				if (_forcedCarryStyle == value)
				{
					return;
				}
				_forcedCarryStyle = value;
				PropertySet(this);
			}
		}

		public CarriedObjectEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
