using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleSwitch : InteractiveMasterDevice
	{
		private CEnum<EAnimationType> _animationType;
		private CFloat _animationSpeed;

		[Ordinal(93)] 
		[RED("animationType")] 
		public CEnum<EAnimationType> AnimationType
		{
			get
			{
				if (_animationType == null)
				{
					_animationType = (CEnum<EAnimationType>) CR2WTypeManager.Create("EAnimationType", "animationType", cr2w, this);
				}
				return _animationType;
			}
			set
			{
				if (_animationType == value)
				{
					return;
				}
				_animationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("animationSpeed")] 
		public CFloat AnimationSpeed
		{
			get
			{
				if (_animationSpeed == null)
				{
					_animationSpeed = (CFloat) CR2WTypeManager.Create("Float", "animationSpeed", cr2w, this);
				}
				return _animationSpeed;
			}
			set
			{
				if (_animationSpeed == value)
				{
					return;
				}
				_animationSpeed = value;
				PropertySet(this);
			}
		}

		public SimpleSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
