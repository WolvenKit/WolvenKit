using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterCyberdeckProgram_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)]  [RED("cyberdeckProgramID")] public TweakDBID CyberdeckProgramID { get; set; }

		public questCharacterCyberdeckProgram_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
