using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterIdleDecoratorParams : CAIIdleParameters
	{
		[RED("reactionTree")] 		public CHandle<CAIMonsterReactionsTree> ReactionTree { get; set;}

		[RED("searchFoodTree")] 		public CHandle<CAIMonsterSearchFoodTree> SearchFoodTree { get; set;}

		[RED("actions", 2,0)] 		public CArray<CHandle<CAIMonsterIdleAction>> Actions { get; set;}

		[RED("nightActions", 2,0)] 		public CArray<CHandle<CAIMonsterIdleAction>> NightActions { get; set;}

		[RED("actionCooldown")] 		public CFloat ActionCooldown { get; set;}

		[RED("chanceToHuntAtNight")] 		public CFloat ChanceToHuntAtNight { get; set;}

		public CAIMonsterIdleDecoratorParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIMonsterIdleDecoratorParams(cr2w);

	}
}