using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDynamicColliderComponent : CComponent
	{
		[Ordinal(1)] [RED("useInWaterNormal")] 		public CBool UseInWaterNormal { get; set;}

		[Ordinal(2)] [RED("useInWaterDisplacement")] 		public CBool UseInWaterDisplacement { get; set;}

		[Ordinal(3)] [RED("useInGrassDisplacement")] 		public CBool UseInGrassDisplacement { get; set;}

		[Ordinal(4)] [RED("useHideFactor")] 		public CBool UseHideFactor { get; set;}

		public CDynamicColliderComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}