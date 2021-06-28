using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioSceneSignalOverride : CVariable
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

		public audioAudioSceneSignalOverride(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
