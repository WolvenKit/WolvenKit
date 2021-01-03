using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
	{
		[Ordinal(0)]  [RED("onlyAlive")] public CBool OnlyAlive { get; set; }

		public StrikeFilterSingle_NPC(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
