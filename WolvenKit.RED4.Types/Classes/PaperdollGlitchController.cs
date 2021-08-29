using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PaperdollGlitchController : inkWidgetLogicController
	{
		private inkWidgetReference _paperdollGlichRoot;
		private CName _glitchAnimationName;

		[Ordinal(1)] 
		[RED("PaperdollGlichRoot")] 
		public inkWidgetReference PaperdollGlichRoot
		{
			get => GetProperty(ref _paperdollGlichRoot);
			set => SetProperty(ref _paperdollGlichRoot, value);
		}

		[Ordinal(2)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get => GetProperty(ref _glitchAnimationName);
			set => SetProperty(ref _glitchAnimationName, value);
		}
	}
}
