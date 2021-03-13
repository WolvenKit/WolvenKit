using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SActionWidgetPackage : SWidgetPackage
	{
		[Ordinal(17)] [RED("action")] public CHandle<gamedeviceAction> Action { get; set; }
		[Ordinal(18)] [RED("wasInitalized")] public CBool WasInitalized { get; set; }
		[Ordinal(19)] [RED("dependendActions")] public CArray<CHandle<gamedeviceAction>> DependendActions { get; set; }

		public SActionWidgetPackage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
