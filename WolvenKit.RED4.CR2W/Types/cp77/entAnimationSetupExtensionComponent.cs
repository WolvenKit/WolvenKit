using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entAnimationSetupExtensionComponent : entIComponent
	{
		private animAnimSetup _animations;
		private CHandle<entAnimationControlBinding> _controlBinding;

		[Ordinal(3)] 
		[RED("animations")] 
		public animAnimSetup Animations
		{
			get => GetProperty(ref _animations);
			set => SetProperty(ref _animations, value);
		}

		[Ordinal(4)] 
		[RED("controlBinding")] 
		public CHandle<entAnimationControlBinding> ControlBinding
		{
			get => GetProperty(ref _controlBinding);
			set => SetProperty(ref _controlBinding, value);
		}

		public entAnimationSetupExtensionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
