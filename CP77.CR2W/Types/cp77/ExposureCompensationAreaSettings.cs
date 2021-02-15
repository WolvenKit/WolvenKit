using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ExposureCompensationAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("exposureCompensation")] public CFloat ExposureCompensation { get; set; }

		public ExposureCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
