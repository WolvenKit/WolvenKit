using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class locVoiceoverLengthMap : ISerializable
	{
		[Ordinal(0)] 
		[RED("entries")] 
		public CArray<locVoLengthEntry> Entries
		{
			get => GetPropertyValue<CArray<locVoLengthEntry>>();
			set => SetPropertyValue<CArray<locVoLengthEntry>>(value);
		}

		public locVoiceoverLengthMap()
		{
			Entries = new();
		}
	}
}
