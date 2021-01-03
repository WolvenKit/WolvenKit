using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InteractiveAdControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("locationAdded")] public CBool LocationAdded { get; set; }
		[Ordinal(1)]  [RED("showAd")] public CBool ShowAd { get; set; }
		[Ordinal(2)]  [RED("showVendor")] public CBool ShowVendor { get; set; }

		public InteractiveAdControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
