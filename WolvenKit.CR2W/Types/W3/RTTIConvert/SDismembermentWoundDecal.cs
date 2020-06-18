using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDismembermentWoundDecal : CVariable
	{
		[RED("materialInfo")] 		public SDynamicDecalMaterialInfo MaterialInfo { get; set;}

		[RED("scale")] 		public Vector2 Scale { get; set;}

		[RED("depthScale")] 		public CFloat DepthScale { get; set;}

		[RED("offset")] 		public Vector2 Offset { get; set;}

		[RED("depthFadePower")] 		public CFloat DepthFadePower { get; set;}

		[RED("normalFadeBias")] 		public CFloat NormalFadeBias { get; set;}

		[RED("normalFadeScale")] 		public CFloat NormalFadeScale { get; set;}

		[RED("doubleSided")] 		public CBool DoubleSided { get; set;}

		[RED("projectionMode")] 		public CEnum<ERenderDynamicDecalProjection> ProjectionMode { get; set;}

		[RED("applyToFillMesh")] 		public CBool ApplyToFillMesh { get; set;}

		public SDismembermentWoundDecal(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SDismembermentWoundDecal(cr2w);

	}
}