using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneSurfaceEffect : CExtAnimCutsceneEvent
	{
		[Ordinal(0)] [RED("("type")] 		public CEnum<ESceneEventSurfacePostFXType> Type { get; set;}

		[Ordinal(0)] [RED("("worldPos")] 		public CBool WorldPos { get; set;}

		[Ordinal(0)] [RED("("position")] 		public Vector Position { get; set;}

		[Ordinal(0)] [RED("("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(0)] [RED("("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[Ordinal(0)] [RED("("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(0)] [RED("("durationTime")] 		public CFloat DurationTime { get; set;}

		public CExtAnimCutsceneSurfaceEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CExtAnimCutsceneSurfaceEffect(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}