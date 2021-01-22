using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Activator : InteractiveMasterDevice
	{
		[Ordinal(0)]  [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }
		[Ordinal(1)]  [RED("defaultDelay")] public CFloat DefaultDelay { get; set; }
		[Ordinal(2)]  [RED("hitCount")] public CInt32 HitCount { get; set; }
		[Ordinal(3)]  [RED("meshAppearence")] public CName MeshAppearence { get; set; }
		[Ordinal(4)]  [RED("meshAppearenceBreaking")] public CName MeshAppearenceBreaking { get; set; }
		[Ordinal(5)]  [RED("meshAppearenceBroken")] public CName MeshAppearenceBroken { get; set; }
		[Ordinal(6)]  [RED("meshComponent")] public CHandle<entMeshComponent> MeshComponent { get; set; }
		[Ordinal(7)]  [RED("redDelay")] public CFloat RedDelay { get; set; }
		[Ordinal(8)]  [RED("yellowDelay")] public CFloat YellowDelay { get; set; }

		public Activator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
