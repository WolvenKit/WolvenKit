using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInventoryComponent : CComponent
	{
		[Ordinal(1)] [RED("containerTemplate")] 		public CHandle<CEntityTemplate> ContainerTemplate { get; set;}

		[Ordinal(2)] [RED("rebalanceEveryNSeconds")] 		public CUInt32 RebalanceEveryNSeconds { get; set;}

		[Ordinal(3)] [RED("turnOffSpawnItemsBudgeting")] 		public CBool TurnOffSpawnItemsBudgeting { get; set;}

		[Ordinal(4)] [RED("priceMult")] 		public CFloat PriceMult { get; set;}

		[Ordinal(5)] [RED("priceRepairMult")] 		public CFloat PriceRepairMult { get; set;}

		[Ordinal(6)] [RED("priceRepair")] 		public CFloat PriceRepair { get; set;}

		[Ordinal(7)] [RED("fundsType")] 		public CEnum<EInventoryFundsType> FundsType { get; set;}

		[Ordinal(8)] [RED("recentlyAddedItems", 2,0)] 		public CArray<SItemUniqueId> RecentlyAddedItems { get; set;}

		[Ordinal(9)] [RED("fundsMax")] 		public CInt32 FundsMax { get; set;}

		[Ordinal(10)] [RED("daysToIncreaseFunds")] 		public CInt32 DaysToIncreaseFunds { get; set;}

		[Ordinal(11)] [RED("listeners", 2,0)] 		public CArray<CHandle<IInventoryScriptedListener>> Listeners { get; set;}

		public CInventoryComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}