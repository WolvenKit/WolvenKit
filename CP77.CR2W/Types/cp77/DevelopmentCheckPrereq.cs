using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("requiredLevel")] public CFloat RequiredLevel { get; set; }

		public DevelopmentCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
