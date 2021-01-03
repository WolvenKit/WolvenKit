using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerParameters_SetAnimset : questICharacterManagerParameters_NodeSubType
	{
		[Ordinal(0)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(1)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(2)]  [RED("value")] public CFloat Value { get; set; }
		[Ordinal(3)]  [RED("variableName")] public CName VariableName { get; set; }

		public questCharacterManagerParameters_SetAnimset(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
