using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioEntityMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("alwaysCreateDefaultEmitter")] public CBool AlwaysCreateDefaultEmitter { get; set; }
		[Ordinal(1)]  [RED("defaultEmitterName")] public CName DefaultEmitterName { get; set; }
		[Ordinal(2)]  [RED("defaultPositionName")] public CName DefaultPositionName { get; set; }
		[Ordinal(3)]  [RED("emitterDescriptions")] public CArray<audioEntityEmitterSettings> EmitterDescriptions { get; set; }
		[Ordinal(4)]  [RED("fallbackDecorators")] public CArray<CName> FallbackDecorators { get; set; }
		[Ordinal(5)]  [RED("isDefaultForEntityType")] public CName IsDefaultForEntityType { get; set; }
		[Ordinal(6)]  [RED("preferSoundComponentPosition")] public CBool PreferSoundComponentPosition { get; set; }
		[Ordinal(7)]  [RED("priority")] public CInt32 Priority { get; set; }
		[Ordinal(8)]  [RED("rigMetadata")] public CName RigMetadata { get; set; }

		public audioEntityMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
