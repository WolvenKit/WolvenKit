using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		private CBool _isShootable;
		private CFloat _animationTime;

		[Ordinal(108)] 
		[RED("isShootable")] 
		public CBool IsShootable
		{
			get
			{
				if (_isShootable == null)
				{
					_isShootable = (CBool) CR2WTypeManager.Create("Bool", "isShootable", cr2w, this);
				}
				return _isShootable;
			}
			set
			{
				if (_isShootable == value)
				{
					return;
				}
				_isShootable = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get
			{
				if (_animationTime == null)
				{
					_animationTime = (CFloat) CR2WTypeManager.Create("Float", "animationTime", cr2w, this);
				}
				return _animationTime;
			}
			set
			{
				if (_animationTime == value)
				{
					return;
				}
				_animationTime = value;
				PropertySet(this);
			}
		}

		public SlidingLadderControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
