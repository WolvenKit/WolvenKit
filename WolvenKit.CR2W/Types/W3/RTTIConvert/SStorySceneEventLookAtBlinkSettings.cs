using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneEventLookAtBlinkSettings : CVariable
	{
		[Ordinal(0)] [RED("("canCloseEyes")] 		public CBool CanCloseEyes { get; set;}

		[Ordinal(0)] [RED("("forceCloseEyes")] 		public CBool ForceCloseEyes { get; set;}

		[Ordinal(0)] [RED("("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(0)] [RED("("startOffset")] 		public CFloat StartOffset { get; set;}

		[Ordinal(0)] [RED("("durationPercent")] 		public CFloat DurationPercent { get; set;}

		[Ordinal(0)] [RED("("horizontalAngleDeg")] 		public CFloat HorizontalAngleDeg { get; set;}

		public SStorySceneEventLookAtBlinkSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneEventLookAtBlinkSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}