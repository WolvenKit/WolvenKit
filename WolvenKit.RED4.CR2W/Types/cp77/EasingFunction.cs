using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EasingFunction : CVariable
	{
		private CEnum<ETransitionType> _transitionType;
		private CEnum<EEasingType> _easingType;

		[Ordinal(0)] 
		[RED("transitionType")] 
		public CEnum<ETransitionType> TransitionType
		{
			get
			{
				if (_transitionType == null)
				{
					_transitionType = (CEnum<ETransitionType>) CR2WTypeManager.Create("ETransitionType", "transitionType", cr2w, this);
				}
				return _transitionType;
			}
			set
			{
				if (_transitionType == value)
				{
					return;
				}
				_transitionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("easingType")] 
		public CEnum<EEasingType> EasingType
		{
			get
			{
				if (_easingType == null)
				{
					_easingType = (CEnum<EEasingType>) CR2WTypeManager.Create("EEasingType", "easingType", cr2w, this);
				}
				return _easingType;
			}
			set
			{
				if (_easingType == value)
				{
					return;
				}
				_easingType = value;
				PropertySet(this);
			}
		}

		public EasingFunction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
