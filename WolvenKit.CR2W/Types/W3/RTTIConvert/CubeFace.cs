using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CubeFace : CVariable
	{
		[Ordinal(0)] [RED("m_texture")] 		public CHandle<CBitmapTexture> M_texture { get; set;}

		[Ordinal(0)] [RED("sourceTexture")] 		public CHandle<CSourceTexture> SourceTexture { get; set;}

		[Ordinal(0)] [RED("m_rotate")] 		public CBool M_rotate { get; set;}

		[Ordinal(0)] [RED("m_flipX")] 		public CBool M_flipX { get; set;}

		[Ordinal(0)] [RED("m_flipY")] 		public CBool M_flipY { get; set;}

		public CubeFace(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CubeFace(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}