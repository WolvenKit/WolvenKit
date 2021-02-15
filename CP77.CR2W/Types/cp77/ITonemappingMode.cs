using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ITonemappingMode : ISerializable
	{
		[Ordinal(0)] [RED("colorPreservation")] public curveData<CFloat> ColorPreservation { get; set; }

		public ITonemappingMode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
