using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class MerchantNPCEmbeddedScenes : CVariable
	{
		[Ordinal(1)] [RED("voiceTag")] 		public CName VoiceTag { get; set;}

		[Ordinal(2)] [RED("storyScene")] 		public CHandle<CStoryScene> StoryScene { get; set;}

		[Ordinal(3)] [RED("input")] 		public CName Input { get; set;}

		[Ordinal(4)] [RED("conditions", 2,0)] 		public CArray<MerchantNPCEmbeddedScenesConditions> Conditions { get; set;}

		public MerchantNPCEmbeddedScenes(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new MerchantNPCEmbeddedScenes(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}