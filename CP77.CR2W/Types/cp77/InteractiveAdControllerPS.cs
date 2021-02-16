using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("showAd")] public CBool ShowAd { get; set; }
		[Ordinal(104)] [RED("showVendor")] public CBool ShowVendor { get; set; }
		[Ordinal(105)] [RED("locationAdded")] public CBool LocationAdded { get; set; }

		public InteractiveAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
