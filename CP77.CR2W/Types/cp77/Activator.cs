using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Activator : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("animFeature")] public CHandle<AnimFeature_SimpleDevice> AnimFeature { get; set; }
		[Ordinal(94)] [RED("hitCount")] public CInt32 HitCount { get; set; }
		[Ordinal(95)] [RED("meshComponent")] public CHandle<entMeshComponent> MeshComponent { get; set; }
		[Ordinal(96)] [RED("meshAppearence")] public CName MeshAppearence { get; set; }
		[Ordinal(97)] [RED("meshAppearenceBreaking")] public CName MeshAppearenceBreaking { get; set; }
		[Ordinal(98)] [RED("meshAppearenceBroken")] public CName MeshAppearenceBroken { get; set; }
		[Ordinal(99)] [RED("defaultDelay")] public CFloat DefaultDelay { get; set; }
		[Ordinal(100)] [RED("yellowDelay")] public CFloat YellowDelay { get; set; }
		[Ordinal(101)] [RED("redDelay")] public CFloat RedDelay { get; set; }

		public Activator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
