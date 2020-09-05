using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterIdleDecoratorParams : CAIIdleParameters
	{
		[Ordinal(1)] [RED("reactionTree")] 		public CHandle<CAIMonsterReactionsTree> ReactionTree { get; set;}

		[Ordinal(2)] [RED("searchFoodTree")] 		public CHandle<CAIMonsterSearchFoodTree> SearchFoodTree { get; set;}

		[Ordinal(3)] [RED("actions", 2,0)] 		public CArray<CHandle<CAIMonsterIdleAction>> Actions { get; set;}

		[Ordinal(4)] [RED("nightActions", 2,0)] 		public CArray<CHandle<CAIMonsterIdleAction>> NightActions { get; set;}

		[Ordinal(5)] [RED("actionCooldown")] 		public CFloat ActionCooldown { get; set;}

		[Ordinal(6)] [RED("chanceToHuntAtNight")] 		public CFloat ChanceToHuntAtNight { get; set;}

		public CAIMonsterIdleDecoratorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterIdleDecoratorParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}