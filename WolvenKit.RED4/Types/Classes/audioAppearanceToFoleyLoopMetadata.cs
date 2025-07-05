using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAppearanceToFoleyLoopMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(1)] 
		[RED("loop")] 
		public audioFoleyLoopMetadata Loop
		{
			get => GetPropertyValue<audioFoleyLoopMetadata>();
			set => SetPropertyValue<audioFoleyLoopMetadata>(value);
		}

		public audioAppearanceToFoleyLoopMetadata()
		{
			Appearances = new();
			Loop = new audioFoleyLoopMetadata();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
