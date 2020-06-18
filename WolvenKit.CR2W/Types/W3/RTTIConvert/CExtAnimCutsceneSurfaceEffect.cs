using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneSurfaceEffect : CExtAnimCutsceneEvent
	{
		[RED("type")] 		public CEnum<ESceneEventSurfacePostFXType> Type { get; set;}

		[RED("worldPos")] 		public CBool WorldPos { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("radius")] 		public CFloat Radius { get; set;}

		[RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[RED("durationTime")] 		public CFloat DurationTime { get; set;}

		public CExtAnimCutsceneSurfaceEffect(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExtAnimCutsceneSurfaceEffect(cr2w);

	}
}