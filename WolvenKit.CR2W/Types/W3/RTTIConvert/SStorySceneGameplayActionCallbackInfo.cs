using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SStorySceneGameplayActionCallbackInfo : CVariable
	{
		[RED("outChangeItems")] 		public CBool OutChangeItems { get; set;}

		[RED("outDontUseSceneTeleport")] 		public CBool OutDontUseSceneTeleport { get; set;}

		[RED("inActorPosition")] 		public Vector InActorPosition { get; set;}

		[RED("inActorHeading")] 		public Vector InActorHeading { get; set;}

		[RED("inGameplayAction")] 		public CInt32 InGameplayAction { get; set;}

		[RED("inActor")] 		public CHandle<CActor> InActor { get; set;}

		public SStorySceneGameplayActionCallbackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SStorySceneGameplayActionCallbackInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}