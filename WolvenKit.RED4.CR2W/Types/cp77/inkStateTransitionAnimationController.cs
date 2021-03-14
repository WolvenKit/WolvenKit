using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStateTransitionAnimationController : inkWidgetLogicController
	{
		private CArray<inkWidgetStateAnimatedTransition> _transition;
		private CBool _stopActiveAnimation;

		[Ordinal(1)] 
		[RED("transition")] 
		public CArray<inkWidgetStateAnimatedTransition> Transition
		{
			get
			{
				if (_transition == null)
				{
					_transition = (CArray<inkWidgetStateAnimatedTransition>) CR2WTypeManager.Create("array:inkWidgetStateAnimatedTransition", "transition", cr2w, this);
				}
				return _transition;
			}
			set
			{
				if (_transition == value)
				{
					return;
				}
				_transition = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("stopActiveAnimation")] 
		public CBool StopActiveAnimation
		{
			get
			{
				if (_stopActiveAnimation == null)
				{
					_stopActiveAnimation = (CBool) CR2WTypeManager.Create("Bool", "stopActiveAnimation", cr2w, this);
				}
				return _stopActiveAnimation;
			}
			set
			{
				if (_stopActiveAnimation == value)
				{
					return;
				}
				_stopActiveAnimation = value;
				PropertySet(this);
			}
		}

		public inkStateTransitionAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
