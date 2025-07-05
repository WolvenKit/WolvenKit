using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAdditionalTransformContainer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<CHandle<animAdditionalTransformEntry>> Entries
		{
			get => GetPropertyValue<CArray<CHandle<animAdditionalTransformEntry>>>();
			set => SetPropertyValue<CArray<CHandle<animAdditionalTransformEntry>>>(value);
		}

		public animAdditionalTransformContainer()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
