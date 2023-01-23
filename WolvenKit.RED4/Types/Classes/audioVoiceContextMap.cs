using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioVoiceContextMap : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<CName> Includes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("contexts")] 
		public CArray<audioVoiceContextMapItem> Contexts
		{
			get => GetPropertyValue<CArray<audioVoiceContextMapItem>>();
			set => SetPropertyValue<CArray<audioVoiceContextMapItem>>(value);
		}

		public audioVoiceContextMap()
		{
			Includes = new();
			Contexts = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
