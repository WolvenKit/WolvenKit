using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventSurfaceEffect : CStorySceneEvent
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<ESceneEventSurfacePostFXType> Type { get; set;}

		[Ordinal(2)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(3)] [RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[Ordinal(4)] [RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(5)] [RED("durationTime")] 		public CFloat DurationTime { get; set;}

		[Ordinal(6)] [RED("radius")] 		public CFloat Radius { get; set;}

		public CStorySceneEventSurfaceEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventSurfaceEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}