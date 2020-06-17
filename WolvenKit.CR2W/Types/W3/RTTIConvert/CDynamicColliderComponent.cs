using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDynamicColliderComponent : CComponent
	{
		[RED("useInWaterNormal")] 		public CBool UseInWaterNormal { get; set;}

		[RED("useInWaterDisplacement")] 		public CBool UseInWaterDisplacement { get; set;}

		[RED("useInGrassDisplacement")] 		public CBool UseInGrassDisplacement { get; set;}

		[RED("useHideFactor")] 		public CBool UseHideFactor { get; set;}

		public CDynamicColliderComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CDynamicColliderComponent(cr2w);

	}
}