using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_Beam_RicochetPreview : gameEffectPostAction
	{
		[Ordinal(0)]  [RED("fromMuzzle")] public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect FromMuzzle { get; set; }
		[Ordinal(1)]  [RED("ricocheted")] public gameEffectPostAction_Beam_RicochetPreviewPreviewEffect Ricocheted { get; set; }

		public gameEffectPostAction_Beam_RicochetPreview(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
