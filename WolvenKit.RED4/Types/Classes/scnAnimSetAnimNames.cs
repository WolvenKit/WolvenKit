using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnAnimSetAnimNames : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationNames")] 
		public CArray<CName> AnimationNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public scnAnimSetAnimNames()
		{
			AnimationNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
