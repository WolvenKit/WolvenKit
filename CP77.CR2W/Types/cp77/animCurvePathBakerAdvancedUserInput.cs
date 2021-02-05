using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerAdvancedUserInput : CVariable
	{
		[Ordinal(0)]  [RED("partsInputs", lignas(8) StaticArray<animCurvePathPartInpu, 3)] public alignas(8) StaticArray<animCurvePathPartInput> PartsInputs { get; set; }

		public animCurvePathBakerAdvancedUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
