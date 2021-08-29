using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioSceneStateOverride : RedBaseClass
	{
		private CName _templateStateName;
		private CName _enterEventOverride;
		private CName _exitEventOverride;

		[Ordinal(0)] 
		[RED("templateStateName")] 
		public CName TemplateStateName
		{
			get => GetProperty(ref _templateStateName);
			set => SetProperty(ref _templateStateName, value);
		}

		[Ordinal(1)] 
		[RED("enterEventOverride")] 
		public CName EnterEventOverride
		{
			get => GetProperty(ref _enterEventOverride);
			set => SetProperty(ref _enterEventOverride, value);
		}

		[Ordinal(2)] 
		[RED("exitEventOverride")] 
		public CName ExitEventOverride
		{
			get => GetProperty(ref _exitEventOverride);
			set => SetProperty(ref _exitEventOverride, value);
		}
	}
}
