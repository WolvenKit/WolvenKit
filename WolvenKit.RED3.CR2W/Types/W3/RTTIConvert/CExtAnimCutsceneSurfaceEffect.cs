using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExtAnimCutsceneSurfaceEffect : CExtAnimCutsceneEvent
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<ESceneEventSurfacePostFXType> Type { get; set;}

		[Ordinal(2)] [RED("worldPos")] 		public CBool WorldPos { get; set;}

		[Ordinal(3)] [RED("position")] 		public Vector Position { get; set;}

		[Ordinal(4)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(5)] [RED("fadeInTime")] 		public CFloat FadeInTime { get; set;}

		[Ordinal(6)] [RED("fadeOutTime")] 		public CFloat FadeOutTime { get; set;}

		[Ordinal(7)] [RED("durationTime")] 		public CFloat DurationTime { get; set;}

		public CExtAnimCutsceneSurfaceEffect(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}