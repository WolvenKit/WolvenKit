using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SetChancePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("setChance")] public CFloat SetChance { get; set; }

		public SetChancePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
