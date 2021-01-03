using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_IntVariable : animAnimNode_IntValue
	{
		[Ordinal(0)]  [RED("variableName")] public CName VariableName { get; set; }

		public animAnimNode_IntVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
