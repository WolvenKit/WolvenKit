using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponShootParams : CVariable
	{
		[Ordinal(0)]  [RED("forward")] public Vector4 Forward { get; set; }
		[Ordinal(1)]  [RED("fromWorldPosition")] public Vector4 FromWorldPosition { get; set; }

		public gameuiWeaponShootParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
