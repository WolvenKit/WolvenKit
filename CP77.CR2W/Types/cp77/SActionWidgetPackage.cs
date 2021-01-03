using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SActionWidgetPackage : SWidgetPackage
	{
		[Ordinal(0)]  [RED("action")] public CHandle<gamedeviceAction> Action { get; set; }
		[Ordinal(1)]  [RED("dependendActions")] public CArray<CHandle<gamedeviceAction>> DependendActions { get; set; }
		[Ordinal(2)]  [RED("wasInitalized")] public CBool WasInitalized { get; set; }

		public SActionWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
