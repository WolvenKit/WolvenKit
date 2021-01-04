using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SoundSystemSettings : CVariable
	{
		[Ordinal(0)]  [RED("canBeUsedAsQuickHack")] public CBool CanBeUsedAsQuickHack { get; set; }
		[Ordinal(1)]  [RED("interactionName")] public TweakDBID InteractionName { get; set; }
		[Ordinal(2)]  [RED("musicSettings")] public CHandle<MusicSettings> MusicSettings { get; set; }

		public SoundSystemSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
