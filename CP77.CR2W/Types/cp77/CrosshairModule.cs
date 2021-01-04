using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrosshairModule : HUDModule
	{
		[Ordinal(0)]  [RED("activeCrosshairs")] public CArray<CHandle<Crosshair>> ActiveCrosshairs { get; set; }

		public CrosshairModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
