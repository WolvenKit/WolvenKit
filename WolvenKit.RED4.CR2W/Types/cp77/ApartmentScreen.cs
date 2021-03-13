using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreen : LcdScreen
	{
		[Ordinal(95)] [RED("timeSystemCallbackID")] public CUInt32 TimeSystemCallbackID { get; set; }

		public ApartmentScreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
