using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsPlaySound : redEvent
	{
		[Ordinal(0)] [RED("soundName")] public CName SoundName { get; set; }
		[Ordinal(1)] [RED("emitterName")] public CName EmitterName { get; set; }
		[Ordinal(2)] [RED("audioTag")] public CName AudioTag { get; set; }
		[Ordinal(3)] [RED("seekTime")] public CFloat SeekTime { get; set; }
		[Ordinal(4)] [RED("playUnique")] public CBool PlayUnique { get; set; }

		public gameaudioeventsPlaySound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
