using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animStackTransformsExtender_JsonProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animStackTransformsExtender_JsonEntry> Entries
		{
			get => GetPropertyValue<CArray<animStackTransformsExtender_JsonEntry>>();
			set => SetPropertyValue<CArray<animStackTransformsExtender_JsonEntry>>(value);
		}

		public animStackTransformsExtender_JsonProperties()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
