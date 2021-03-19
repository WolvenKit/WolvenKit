using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimStateTransitionInterpolator_Blend_ : animIAnimStateTransitionInterpolator
	{
		private CEnum<animAnimStateInterpolationType> _interpolationType;

		[Ordinal(0)] 
		[RED("interpolationType")] 
		public CEnum<animAnimStateInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		public animAnimStateTransitionInterpolator_Blend_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
