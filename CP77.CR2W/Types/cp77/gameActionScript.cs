using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameActionScript : gameIObjectScriptBase
	{
		[Ordinal(0)]  [RED("actionFlags")] public CUInt32 ActionFlags { get; set; }

		public gameActionScript(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
