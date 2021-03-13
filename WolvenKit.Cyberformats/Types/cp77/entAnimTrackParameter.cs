using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entAnimTrackParameter : CVariable
	{
		[Ordinal(0)] [RED("animTrackName")] public CName AnimTrackName { get; set; }
		[Ordinal(1)] [RED("parameterName")] public CName ParameterName { get; set; }
		[Ordinal(2)] [RED("defaultValue")] public CFloat DefaultValue { get; set; }

		public entAnimTrackParameter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
