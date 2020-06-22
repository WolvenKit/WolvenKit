using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CPhantomWeaponManager : CObject
	{
		[RED("hitsToCharge")] 		public CInt32 HitsToCharge { get; set;}

		[RED("timeToDischarge")] 		public CFloat TimeToDischarge { get; set;}

		[RED("minVitalityPercToCharge")] 		public CFloat MinVitalityPercToCharge { get; set;}

		[RED("vitalityPercLostOnDischarge")] 		public CFloat VitalityPercLostOnDischarge { get; set;}

		[RED("hitCounter")] 		public CInt32 HitCounter { get; set;}

		[RED("isWeaponCharged")] 		public CBool IsWeaponCharged { get; set;}

		[RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[RED("inv")] 		public CHandle<CInventoryComponent> Inv { get; set;}

		[RED("chargedLoopedFxName")] 		public CName ChargedLoopedFxName { get; set;}

		[RED("chargedSingleFxName")] 		public CName ChargedSingleFxName { get; set;}

		public CPhantomWeaponManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CPhantomWeaponManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}