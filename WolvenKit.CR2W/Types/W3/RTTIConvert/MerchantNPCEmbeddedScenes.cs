using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class MerchantNPCEmbeddedScenes : CVariable
	{
		[RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[RED("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[RED("input")] 		public CName Input { get; set;}

		[RED("conditions", 2,0)] 		public CArray<MerchantNPCEmbeddedScenesConditions> Conditions { get; set;}

		public MerchantNPCEmbeddedScenes(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new MerchantNPCEmbeddedScenes(cr2w);

	}
}