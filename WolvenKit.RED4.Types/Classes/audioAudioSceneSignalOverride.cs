using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioSceneSignalOverride : RedBaseClass
	{
		private CName _templateSignal;
		private CName _signalOverride;

		[Ordinal(0)] 
		[RED("templateSignal")] 
		public CName TemplateSignal
		{
			get => GetProperty(ref _templateSignal);
			set => SetProperty(ref _templateSignal, value);
		}

		[Ordinal(1)] 
		[RED("signalOverride")] 
		public CName SignalOverride
		{
			get => GetProperty(ref _signalOverride);
			set => SetProperty(ref _signalOverride, value);
		}
	}
}
