using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventSurfaceEffect : CStorySceneEvent
	{
		[RED("type")] 		public CEnum<ESceneEventSurfacePostFXType> Type { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("durationTime")] 		public CFloat DurationTime { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		public CStorySceneEventSurfaceEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventSurfaceEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}