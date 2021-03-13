using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleDoorsSettings : CVariable
	{
		[Ordinal(0)] [RED("openEvent")] public CName OpenEvent { get; set; }
		[Ordinal(1)] [RED("closeEvent")] public CName CloseEvent { get; set; }

		public audioVehicleDoorsSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
