using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskGetFoodNearby : IBehTreeTask
	{
		[Ordinal(0)] [RED("foodToLookFor")] 		public CInt32 FoodToLookFor { get; set;}

		[Ordinal(0)] [RED("completeIfTargetChange")] 		public CBool CompleteIfTargetChange { get; set;}

		[Ordinal(0)] [RED("m_foodFound")] 		public CHandle<W3FoodComponent> M_foodFound { get; set;}

		[Ordinal(0)] [RED("m_scentFound")] 		public CHandle<W3ScentComponent> M_scentFound { get; set;}

		[Ordinal(0)] [RED("m_alreadyTrackedScents", 2,0)] 		public CArray<CHandle<W3ScentComponent>> M_alreadyTrackedScents { get; set;}

		[Ordinal(0)] [RED("m_timeAtLastCheck")] 		public CFloat M_timeAtLastCheck { get; set;}

		[Ordinal(0)] [RED("m_delayBetweenChecks")] 		public CFloat M_delayBetweenChecks { get; set;}

		[Ordinal(0)] [RED("m_WasFalse")] 		public CBool M_WasFalse { get; set;}

		[Ordinal(0)] [RED("m_EntitiesAround", 2,0)] 		public CArray<CHandle<CGameplayEntity>> M_EntitiesAround { get; set;}

		[Ordinal(0)] [RED("m_delayBetweenUpdateEntities")] 		public CFloat M_delayBetweenUpdateEntities { get; set;}

		[Ordinal(0)] [RED("m_timeAtLastUpdateEntities")] 		public CFloat M_timeAtLastUpdateEntities { get; set;}

		public BTTaskGetFoodNearby(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskGetFoodNearby(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}