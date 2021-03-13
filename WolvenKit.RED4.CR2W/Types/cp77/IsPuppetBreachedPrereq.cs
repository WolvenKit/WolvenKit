using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPuppetBreachedPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("isBreached")] public CBool IsBreached { get; set; }

		public IsPuppetBreachedPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
