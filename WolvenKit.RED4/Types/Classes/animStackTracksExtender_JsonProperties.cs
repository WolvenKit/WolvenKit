using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animStackTracksExtender_JsonProperties : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<animStackTracksExtender_JsonEntry> Entries
		{
			get => GetPropertyValue<CArray<animStackTracksExtender_JsonEntry>>();
			set => SetPropertyValue<CArray<animStackTracksExtender_JsonEntry>>(value);
		}

		public animStackTracksExtender_JsonProperties()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
