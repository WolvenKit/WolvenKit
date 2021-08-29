using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioSceneDefaults : audioAudioMetadata
	{
		private CArray<audioAudSimpleParameter> _parameters;

		[Ordinal(1)] 
		[RED("parameters")] 
		public CArray<audioAudSimpleParameter> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}
	}
}
