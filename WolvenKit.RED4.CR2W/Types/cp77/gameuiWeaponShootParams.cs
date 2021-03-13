using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponShootParams : CVariable
	{
		[Ordinal(0)] [RED("fromWorldPosition")] public Vector4 FromWorldPosition { get; set; }
		[Ordinal(1)] [RED("forward")] public Vector4 Forward { get; set; }

		public gameuiWeaponShootParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
