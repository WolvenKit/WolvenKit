using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockOutputColorHair : CMaterialRootBlock
	{
		[Ordinal(1)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[Ordinal(2)] [RED("rawOutput")] 		public CBool RawOutput { get; set;}

		[Ordinal(3)] [RED("maskThreshold")] 		public CFloat MaskThreshold { get; set;}

		[Ordinal(4)] [RED("implicitGlobalFogVertexBased")] 		public CBool ImplicitGlobalFogVertexBased { get; set;}

		[Ordinal(5)] [RED("shadowingSolidVertexBased")] 		public CBool ShadowingSolidVertexBased { get; set;}

		[Ordinal(6)] [RED("shadowingTransparentVertexBased")] 		public CBool ShadowingTransparentVertexBased { get; set;}

		[Ordinal(7)] [RED("shadowingCascadesVertexBased")] 		public CBool ShadowingCascadesVertexBased { get; set;}

		[Ordinal(8)] [RED("envProbesSolidVertexBased")] 		public CBool EnvProbesSolidVertexBased { get; set;}

		[Ordinal(9)] [RED("envProbesTransparentVertexBased")] 		public CBool EnvProbesTransparentVertexBased { get; set;}

		public CMaterialBlockOutputColorHair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockOutputColorHair(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}