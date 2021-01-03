using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameCookedDeviceData : CVariable
	{
		[Ordinal(0)]  [RED("children")] public CArray<CUInt64> Children { get; set; }
		[Ordinal(1)]  [RED("className")] public CName ClassName { get; set; }
		[Ordinal(2)]  [RED("nodePosition")] public Vector3 NodePosition { get; set; }
		[Ordinal(3)]  [RED("parents")] public CArray<CUInt64> Parents { get; set; }

		public gameCookedDeviceData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
