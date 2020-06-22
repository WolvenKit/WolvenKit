using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventRotate : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("angle")] 		public CFloat Angle { get; set;}

		[RED("absoluteAngle")] 		public CBool AbsoluteAngle { get; set;}

		[RED("toCamera")] 		public CBool ToCamera { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		public CStorySceneEventRotate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventRotate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}