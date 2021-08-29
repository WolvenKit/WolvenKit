using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioAudioAttractAreaSounds : audioAudioMetadata
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
	}
}
