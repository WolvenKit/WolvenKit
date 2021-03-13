using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhantomWeaponManager : CObject
	{
		[Ordinal(1)] [RED("hitsToCharge")] 		public CInt32 HitsToCharge { get; set;}

		[Ordinal(2)] [RED("timeToDischarge")] 		public CFloat TimeToDischarge { get; set;}

		[Ordinal(3)] [RED("minVitalityPercToCharge")] 		public CFloat MinVitalityPercToCharge { get; set;}

		[Ordinal(4)] [RED("vitalityPercLostOnDischarge")] 		public CFloat VitalityPercLostOnDischarge { get; set;}

		[Ordinal(5)] [RED("hitCounter")] 		public CInt32 HitCounter { get; set;}

		[Ordinal(6)] [RED("isWeaponCharged")] 		public CBool IsWeaponCharged { get; set;}

		[Ordinal(7)] [RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[Ordinal(8)] [RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[Ordinal(9)] [RED("chargedLoopedFxName")] 		public CName ChargedLoopedFxName { get; set;}

		[Ordinal(10)] [RED("chargedSingleFxName")] 		public CName ChargedSingleFxName { get; set;}

		public CPhantomWeaponManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhantomWeaponManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}