using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockOutputColor : CMaterialRootBlock
	{
		[Ordinal(1)] [RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[Ordinal(2)] [RED("noDepthWrite")] 		public CBool NoDepthWrite { get; set;}

		[Ordinal(3)] [RED("inputColorLinear")] 		public CBool InputColorLinear { get; set;}

		[Ordinal(4)] [RED("maskThreshold")] 		public CFloat MaskThreshold { get; set;}

		[Ordinal(5)] [RED("blendMode")] 		public CEnum<ERenderingBlendMode> BlendMode { get; set;}

		[Ordinal(6)] [RED("checkRefractionDepth")] 		public CBool CheckRefractionDepth { get; set;}

		[Ordinal(7)] [RED("implicitTransparencyColor")] 		public CBool ImplicitTransparencyColor { get; set;}

		[Ordinal(8)] [RED("implicitTransparencyAlpha")] 		public CBool ImplicitTransparencyAlpha { get; set;}

		[Ordinal(9)] [RED("implicitGlobalFogVertexBased")] 		public CBool ImplicitGlobalFogVertexBased { get; set;}

		[Ordinal(10)] [RED("implicitGlobalFog")] 		public CBool ImplicitGlobalFog { get; set;}

		public CMaterialBlockOutputColor(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}