using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMorphedMeshManagerComponent : CComponent
	{
		[Ordinal(1)] [RED("Default morph ratio")] 		public CFloat Default_morph_ratio { get; set;}

		[Ordinal(2)] [RED("morphCurve")] 		public CHandle<CCurve> MorphCurve { get; set;}

		[Ordinal(3)] [RED("morphRatio")] 		public CFloat MorphRatio { get; set;}

		[Ordinal(4)] [RED("testBlend")] 		public CBool TestBlend { get; set;}

		public CMorphedMeshManagerComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}