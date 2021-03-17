using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseVehicleHUDGameController : gameuiHUDGameController
	{
		private CBool _mounted;

		[Ordinal(9)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetProperty(ref _mounted);
			set => SetProperty(ref _mounted, value);
		}

		public gameuiBaseVehicleHUDGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
