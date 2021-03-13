using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Speaker : InteractiveDevice
	{
		[Ordinal(93)] [RED("soundEventPlaying")] public CBool SoundEventPlaying { get; set; }
		[Ordinal(94)] [RED("soundEvent")] public CName SoundEvent { get; set; }
		[Ordinal(95)] [RED("effectRef")] public gameEffectRef EffectRef { get; set; }
		[Ordinal(96)] [RED("deafGameEffect")] public CHandle<gameEffectInstance> DeafGameEffect { get; set; }
		[Ordinal(97)] [RED("targets")] public CArray<wCHandle<ScriptedPuppet>> Targets { get; set; }
		[Ordinal(98)] [RED("statusEffect")] public TweakDBID StatusEffect { get; set; }

		public Speaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
