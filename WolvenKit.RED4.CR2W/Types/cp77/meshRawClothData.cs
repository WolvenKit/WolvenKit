using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class meshRawClothData : CVariable
	{
		[Ordinal(0)] [RED("state")] public physicsclothState State { get; set; }
		[Ordinal(1)] [RED("maxDistanceChannel")] public CArray<DataBuffer> MaxDistanceChannel { get; set; }
		[Ordinal(2)] [RED("maxDistanceExtChannel")] public CArray<DataBuffer> MaxDistanceExtChannel { get; set; }
		[Ordinal(3)] [RED("backstopDistanceChannel")] public CArray<DataBuffer> BackstopDistanceChannel { get; set; }
		[Ordinal(4)] [RED("backstopRadiusChannel")] public CArray<DataBuffer> BackstopRadiusChannel { get; set; }
		[Ordinal(5)] [RED("selfCollisionChannel")] public CArray<DataBuffer> SelfCollisionChannel { get; set; }

		public meshRawClothData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
