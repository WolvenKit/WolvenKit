using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMaterialBlockOutputColor : CMaterialRootBlock
	{
		[RED("isTwoSided")] 		public CBool IsTwoSided { get; set;}

		[RED("noDepthWrite")] 		public CBool NoDepthWrite { get; set;}

		[RED("inputColorLinear")] 		public CBool InputColorLinear { get; set;}

		[RED("maskThreshold")] 		public CFloat MaskThreshold { get; set;}

		[RED("blendMode")] 		public CEnum<ERenderingBlendMode> BlendMode { get; set;}

		[RED("checkRefractionDepth")] 		public CBool CheckRefractionDepth { get; set;}

		[RED("implicitTransparencyColor")] 		public CBool ImplicitTransparencyColor { get; set;}

		[RED("implicitTransparencyAlpha")] 		public CBool ImplicitTransparencyAlpha { get; set;}

		[RED("implicitGlobalFogVertexBased")] 		public CBool ImplicitGlobalFogVertexBased { get; set;}

		[RED("implicitGlobalFog")] 		public CBool ImplicitGlobalFog { get; set;}

		public CMaterialBlockOutputColor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMaterialBlockOutputColor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}