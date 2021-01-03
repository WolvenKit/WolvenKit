using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animCurvePathBakerAdvancedUserInput : CVariable
	{
		[Ordinal(0)]  [RED("partsInputs", 3)] public CStatic<animCurvePathPartInput> PartsInputs { get; set; }

		public animCurvePathBakerAdvancedUserInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
