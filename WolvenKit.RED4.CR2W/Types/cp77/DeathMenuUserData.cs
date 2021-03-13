using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeathMenuUserData : IScriptable
	{
		[Ordinal(0)] [RED("playInitAnimation")] public CBool PlayInitAnimation { get; set; }

		public DeathMenuUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
