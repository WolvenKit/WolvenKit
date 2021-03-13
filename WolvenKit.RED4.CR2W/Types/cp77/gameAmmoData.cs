using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAmmoData : CVariable
	{
		[Ordinal(0)] [RED("id")] public gameItemID Id { get; set; }
		[Ordinal(1)] [RED("available")] public CInt32 Available { get; set; }
		[Ordinal(2)] [RED("equipped")] public CInt32 Equipped { get; set; }

		public gameAmmoData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
