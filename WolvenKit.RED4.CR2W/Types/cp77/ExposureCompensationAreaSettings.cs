using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExposureCompensationAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("exposureCompensation")] public CFloat ExposureCompensation { get; set; }

		public ExposureCompensationAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
