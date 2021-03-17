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
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(2)] 
		[RED("animationPriority")] 
		public CInt32 AnimationPriority
		{
			get => GetProperty(ref _animationPriority);
			set => SetProperty(ref _animationPriority, value);
		}

		public TargetHitIndicatorLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
