using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDecalComponent : CDrawableComponent
	{
		[RED("diffuseTexture")] 		public CHandle<CBitmapTexture> DiffuseTexture { get; set;}

		[RED("specularity")] 		public CFloat Specularity { get; set;}

		[RED("specularColor")] 		public CColor SpecularColor { get; set;}

		[RED("normalThreshold")] 		public CFloat NormalThreshold { get; set;}

		[RED("autoHideDistance")] 		public CFloat AutoHideDistance { get; set;}

		[RED("verticalFlip")] 		public CBool VerticalFlip { get; set;}

		[RED("horizontalFlip")] 		public CBool HorizontalFlip { get; set;}

		[RED("fadeTime")] 		public CFloat FadeTime { get; set;}

		public CDecalComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDecalComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}