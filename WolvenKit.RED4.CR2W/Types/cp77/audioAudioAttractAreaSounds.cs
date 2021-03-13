using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioAttractAreaSounds : audioAudioMetadata
	{
		[Ordinal(1)] [RED("NPCgrunts")] public CArray<audioDynamicEventsPerVisualTags> NPCgrunts { get; set; }
		[Ordinal(2)] [RED("environmentSounds")] public CArray<audioDynamicEventsWithInterval> EnvironmentSounds { get; set; }

		public audioAudioAttractAreaSounds(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
