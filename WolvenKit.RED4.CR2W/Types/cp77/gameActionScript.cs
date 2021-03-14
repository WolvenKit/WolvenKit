using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionScript : gameIObjectScriptBase
	{
		[Ordinal(1)] [RED("actionFlags")] public CUInt32 ActionFlags { get; set; }

		public gameActionScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
