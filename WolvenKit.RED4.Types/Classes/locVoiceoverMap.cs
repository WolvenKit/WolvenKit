using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class locVoiceoverMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLineEntry> Entries
		{
			get => GetPropertyValue<CArray<locVoLineEntry>>();
			set => SetPropertyValue<CArray<locVoLineEntry>>(value);
		}

		public locVoiceoverMap()
		{
			Entries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
