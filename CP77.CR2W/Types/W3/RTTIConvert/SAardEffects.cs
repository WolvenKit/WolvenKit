using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAardEffects : CVariable
	{
		[Ordinal(1)] [RED("baseCommonThrowEffect")] 		public CName BaseCommonThrowEffect { get; set;}

		[Ordinal(2)] [RED("baseCommonThrowEffectUpgrade1")] 		public CName BaseCommonThrowEffectUpgrade1 { get; set;}

		[Ordinal(3)] [RED("baseCommonThrowEffectUpgrade2")] 		public CName BaseCommonThrowEffectUpgrade2 { get; set;}

		[Ordinal(4)] [RED("baseCommonThrowEffectUpgrade3")] 		public CName BaseCommonThrowEffectUpgrade3 { get; set;}

		[Ordinal(5)] [RED("throwEffectSoil")] 		public CName ThrowEffectSoil { get; set;}

		[Ordinal(6)] [RED("throwEffectSoilUpgrade1")] 		public CName ThrowEffectSoilUpgrade1 { get; set;}

		[Ordinal(7)] [RED("throwEffectSoilUpgrade2")] 		public CName ThrowEffectSoilUpgrade2 { get; set;}

		[Ordinal(8)] [RED("throwEffectSoilUpgrade3")] 		public CName ThrowEffectSoilUpgrade3 { get; set;}

		[Ordinal(9)] [RED("throwEffectSPNoUpgrade")] 		public CName ThrowEffectSPNoUpgrade { get; set;}

		[Ordinal(10)] [RED("throwEffectSPUpgrade1")] 		public CName ThrowEffectSPUpgrade1 { get; set;}

		[Ordinal(11)] [RED("throwEffectSPUpgrade2")] 		public CName ThrowEffectSPUpgrade2 { get; set;}

		[Ordinal(12)] [RED("throwEffectSPUpgrade3")] 		public CName ThrowEffectSPUpgrade3 { get; set;}

		[Ordinal(13)] [RED("throwEffectDmgNoUpgrade")] 		public CName ThrowEffectDmgNoUpgrade { get; set;}

		[Ordinal(14)] [RED("throwEffectDmgUpgrade1")] 		public CName ThrowEffectDmgUpgrade1 { get; set;}

		[Ordinal(15)] [RED("throwEffectDmgUpgrade2")] 		public CName ThrowEffectDmgUpgrade2 { get; set;}

		[Ordinal(16)] [RED("throwEffectDmgUpgrade3")] 		public CName ThrowEffectDmgUpgrade3 { get; set;}

		[Ordinal(17)] [RED("throwEffectWater")] 		public CName ThrowEffectWater { get; set;}

		[Ordinal(18)] [RED("throwEffectWaterUpgrade1")] 		public CName ThrowEffectWaterUpgrade1 { get; set;}

		[Ordinal(19)] [RED("throwEffectWaterUpgrade2")] 		public CName ThrowEffectWaterUpgrade2 { get; set;}

		[Ordinal(20)] [RED("throwEffectWaterUpgrade3")] 		public CName ThrowEffectWaterUpgrade3 { get; set;}

		[Ordinal(21)] [RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		public SAardEffects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAardEffects(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}