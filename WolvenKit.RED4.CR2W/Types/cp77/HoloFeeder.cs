using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloFeeder : Device
	{
		[Ordinal(86)] [RED("feederMesh")] public CHandle<entIPlacedComponent> FeederMesh { get; set; }

		public HoloFeeder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
