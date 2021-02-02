using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameUILocalizationDataPackage : IScriptable
	{
		[Ordinal(0)]  [RED("floatValues")] public CArray<CFloat> FloatValues { get; set; }
		[Ordinal(1)]  [RED("intValues")] public CArray<CInt32> IntValues { get; set; }
		[Ordinal(2)]  [RED("nameValues")] public CArray<CName> NameValues { get; set; }
		[Ordinal(3)]  [RED("statValues")] public CArray<CFloat> StatValues { get; set; }
		[Ordinal(4)]  [RED("statNames")] public CArray<CName> StatNames { get; set; }
		[Ordinal(5)]  [RED("paramsCount")] public CInt32 ParamsCount { get; set; }
		[Ordinal(6)]  [RED("textParams")] public CHandle<textTextParameterSet> TextParams { get; set; }

		public gameUILocalizationDataPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
