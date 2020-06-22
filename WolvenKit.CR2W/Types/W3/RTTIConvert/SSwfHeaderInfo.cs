using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSwfHeaderInfo : CVariable
	{
		[RED("frameRate")] 		public CFloat FrameRate { get; set;}

		[RED("frameHeight")] 		public CFloat FrameHeight { get; set;}

		[RED("frameWidth")] 		public CFloat FrameWidth { get; set;}

		[RED("frameCount")] 		public CUInt32 FrameCount { get; set;}

		[RED("height")] 		public CFloat Height { get; set;}

		[RED("width")] 		public CFloat Width { get; set;}

		[RED("version")] 		public CUInt32 Version { get; set;}

		[RED("compressed")] 		public CBool Compressed { get; set;}

		public SSwfHeaderInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSwfHeaderInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}