using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioAttractAreaSounds : audioAudioMetadata
	{
		private CArray<audioDynamicEventsPerVisualTags> _nPCgrunts;
		private CArray<audioDynamicEventsWithInterval> _environmentSounds;

		[Ordinal(1)] 
		[RED("NPCgrunts")] 
		public CArray<audioDynamicEventsPerVisualTags> NPCgrunts
		{
			get => GetProperty(ref _nPCgrunts);
			set => SetProperty(ref _nPCgrunts, value);
		}

		[Ordinal(2)] 
		[RED("environmentSounds")] 
		public CArray<audioDynamicEventsWithInterval> EnvironmentSounds
		{
			get => GetProperty(ref _environmentSounds);
			set => SetProperty(ref _environmentSounds, value);
		}

		public audioAudioAttractAreaSounds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
