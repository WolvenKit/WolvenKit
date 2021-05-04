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
			get => GetProperty(ref _transitionType);
			set => SetProperty(ref _transitionType, value);
		}

		[Ordinal(1)] 
		[RED("easingType")] 
		public CEnum<EEasingType> EasingType
		{
			get => GetProperty(ref _easingType);
			set => SetProperty(ref _easingType, value);
		}

		public EasingFunction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
