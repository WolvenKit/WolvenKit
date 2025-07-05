using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVisualTagToFoleyLoopMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("visualtags")] 
		public CArray<CName> Visualtags
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

		public audioVisualTagToFoleyLoopMetadata()
		{
			Visualtags = new();
			Loop = new audioFoleyLoopMetadata();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
