using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Speaker : InteractiveDevice
	{
		[Ordinal(0)]  [RED("deafGameEffect")] public CHandle<gameEffectInstance> DeafGameEffect { get; set; }
		[Ordinal(1)]  [RED("effectRef")] public gameEffectRef EffectRef { get; set; }
		[Ordinal(2)]  [RED("soundEvent")] public CName SoundEvent { get; set; }
		[Ordinal(3)]  [RED("soundEventPlaying")] public CBool SoundEventPlaying { get; set; }
		[Ordinal(4)]  [RED("statusEffect")] public TweakDBID StatusEffect { get; set; }
		[Ordinal(5)]  [RED("targets")] public CArray<wCHandle<ScriptedPuppet>> Targets { get; set; }

		public Speaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
