using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetHitIndicatorLogicController : inkWidgetLogicController
	{
		private CName _animName;
		private CInt32 _animationPriority;

		[Ordinal(1)] 
		[RED("animName")] 
		public CName AnimName
		{
			get
			{
				if (_animName == null)
				{
					_animName = (CName) CR2WTypeManager.Create("CName", "animName", cr2w, this);
				}
				return _animName;
			}
			set
			{
				if (_animName == value)
				{
					return;
				}
				_animName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("animationPriority")] 
		public CInt32 AnimationPriority
		{
			get
			{
				if (_animationPriority == null)
				{
					_animationPriority = (CInt32) CR2WTypeManager.Create("Int32", "animationPriority", cr2w, this);
				}
				return _animationPriority;
			}
			set
			{
				if (_animationPriority == value)
				{
					return;
				}
				_animationPriority = value;
				PropertySet(this);
			}
		}

		public TargetHitIndicatorLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
