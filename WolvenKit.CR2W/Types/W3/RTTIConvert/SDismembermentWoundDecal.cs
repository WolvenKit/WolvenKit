using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SDismembermentWoundDecal : CVariable
	{
		[Ordinal(1)] [RED("materialInfo")] 		public SDynamicDecalMaterialInfo MaterialInfo { get; set;}

		[Ordinal(2)] [RED("scale")] 		public Vector2 Scale { get; set;}

		[Ordinal(3)] [RED("depthScale")] 		public CFloat DepthScale { get; set;}

		[Ordinal(4)] [RED("offset")] 		public Vector2 Offset { get; set;}

		[Ordinal(5)] [RED("depthFadePower")] 		public CFloat DepthFadePower { get; set;}

		[Ordinal(6)] [RED("normalFadeBias")] 		public CFloat NormalFadeBias { get; set;}

		[Ordinal(7)] [RED("normalFadeScale")] 		public CFloat NormalFadeScale { get; set;}

		[Ordinal(8)] [RED("doubleSided")] 		public CBool DoubleSided { get; set;}

		[Ordinal(9)] [RED("projectionMode")] 		public CEnum<ERenderDynamicDecalProjection> ProjectionMode { get; set;}

		[Ordinal(10)] [RED("applyToFillMesh")] 		public CBool ApplyToFillMesh { get; set;}

		public SDismembermentWoundDecal(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SDismembermentWoundDecal(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}