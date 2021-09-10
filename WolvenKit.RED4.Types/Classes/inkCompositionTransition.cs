using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCompositionTransition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("targetState")] 
		public CName TargetState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("interpolators")] 
		public CArray<inkCompositionInterpolator> Interpolators
		{
			get => GetPropertyValue<CArray<inkCompositionInterpolator>>();
			set => SetPropertyValue<CArray<inkCompositionInterpolator>>(value);
		}

		public inkCompositionTransition()
		{
			Interpolators = new();
		}
	}
}
