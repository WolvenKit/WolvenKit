using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimWrapperVariableDescription : CVariable
	{
		[Ordinal(0)]  [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(1)]  [RED("variableName")] public CName VariableName { get; set; }

		public animAnimWrapperVariableDescription(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
