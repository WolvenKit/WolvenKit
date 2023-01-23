using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioAttractAreaSounds : audioAudioMetadata
	{
		[Ordinal(1)] 
		[RED("NPCgrunts")] 
		public CArray<audioDynamicEventsPerVisualTags> NPCgrunts
		{
			get => GetPropertyValue<CArray<audioDynamicEventsPerVisualTags>>();
			set => SetPropertyValue<CArray<audioDynamicEventsPerVisualTags>>(value);
		}

		[Ordinal(2)] 
		[RED("environmentSounds")] 
		public CArray<audioDynamicEventsWithInterval> EnvironmentSounds
		{
			get => GetPropertyValue<CArray<audioDynamicEventsWithInterval>>();
			set => SetPropertyValue<CArray<audioDynamicEventsWithInterval>>(value);
		}

		public audioAudioAttractAreaSounds()
		{
			NPCgrunts = new();
			EnvironmentSounds = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
