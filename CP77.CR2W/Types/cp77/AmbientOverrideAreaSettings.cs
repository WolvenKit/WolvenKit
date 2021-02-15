using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AmbientOverrideAreaSettings : IAreaSettings
	{
		[Ordinal(2)] [RED("color", 6)] public CArrayFixedSize<curveData<HDRColor>> Color { get; set; }

		public AmbientOverrideAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
