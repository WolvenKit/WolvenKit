using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneOutput : CStorySceneControlPart
	{
		[Ordinal(1)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(2)] [RED("questOutput")] 		public CBool QuestOutput { get; set;}

		[Ordinal(3)] [RED("endsWithBlackscreen")] 		public CBool EndsWithBlackscreen { get; set;}

		[Ordinal(4)] [RED("blackscreenColor")] 		public CColor BlackscreenColor { get; set;}

		[Ordinal(5)] [RED("gameplayCameraBlendTime")] 		public CFloat GameplayCameraBlendTime { get; set;}

		[Ordinal(6)] [RED("environmentLightsBlendTime")] 		public CFloat EnvironmentLightsBlendTime { get; set;}

		[Ordinal(7)] [RED("gameplayCameraUseFocusTarget")] 		public CBool GameplayCameraUseFocusTarget { get; set;}

		[Ordinal(8)] [RED("action")] 		public CEnum<EStorySceneOutputAction> Action { get; set;}

		public CStorySceneOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneOutput(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}