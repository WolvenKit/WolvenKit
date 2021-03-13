using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStyleProperty : CVariable
	{
		[Ordinal(0)] [RED("propertyPath")] public CName PropertyPath { get; set; }
		[Ordinal(1)] [RED("value")] public CVariant Value { get; set; }

		public inkStyleProperty(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
