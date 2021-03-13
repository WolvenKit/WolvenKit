using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleDestructionPSData : CVariable
	{
		[Ordinal(0)] [RED("gridValues", 30)] public CArrayFixedSize<CFloat> GridValues { get; set; }
		[Ordinal(1)] [RED("brokenGlass")] public CUInt32 BrokenGlass { get; set; }
		[Ordinal(2)] [RED("brokenLights")] public CUInt32 BrokenLights { get; set; }
		[Ordinal(3)] [RED("flatTire")] public CUInt8 FlatTire { get; set; }
		[Ordinal(4)] [RED("windshieldShattered")] public CBool WindshieldShattered { get; set; }
		[Ordinal(5)] [RED("windshieldPoints")] public CArray<Vector3> WindshieldPoints { get; set; }
		[Ordinal(6)] [RED("detachedParts")] public CArray<CName> DetachedParts { get; set; }

		public vehicleDestructionPSData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
