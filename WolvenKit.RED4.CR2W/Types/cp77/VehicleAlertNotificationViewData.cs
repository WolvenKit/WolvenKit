using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleAlertNotificationViewData : gameuiGenericNotificationViewData
	{
		[Ordinal(5)] [RED("canBeMerged")] public CBool CanBeMerged { get; set; }

		public VehicleAlertNotificationViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
