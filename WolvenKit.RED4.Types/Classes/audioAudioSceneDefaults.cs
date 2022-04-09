using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioSceneDefaults : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("parameters")] 
		public CArray<audioAudSimpleParameter> Parameters
		{
			get => GetPropertyValue<CArray<audioAudSimpleParameter>>();
			set => SetPropertyValue<CArray<audioAudSimpleParameter>>(value);
		}

		public audioAudioSceneDefaults()
		{
			Parameters = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
