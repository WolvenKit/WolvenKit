using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneStateOverride : CVariable
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

		public audioAudioSceneStateOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
