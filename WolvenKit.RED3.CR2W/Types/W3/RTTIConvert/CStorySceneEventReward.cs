using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventReward : CStorySceneEvent
	{
		[Ordinal(1)] [RED("npcTag")] 		public CName NpcTag { get; set;}

		[Ordinal(2)] [RED("itemName")] 		public CName ItemName { get; set;}

		[Ordinal(3)] [RED("rewardName")] 		public CName RewardName { get; set;}

		[Ordinal(4)] [RED("quantity")] 		public CInt32 Quantity { get; set;}

		[Ordinal(5)] [RED("dontInformGui")] 		public CBool DontInformGui { get; set;}

		public CStorySceneEventReward(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventReward(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}