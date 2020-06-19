using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAardEffects : CVariable
	{
		[RED("baseCommonThrowEffect")] 		public CName BaseCommonThrowEffect { get; set;}

		[RED("baseCommonThrowEffectUpgrade1")] 		public CName BaseCommonThrowEffectUpgrade1 { get; set;}

		[RED("baseCommonThrowEffectUpgrade2")] 		public CName BaseCommonThrowEffectUpgrade2 { get; set;}

		[RED("baseCommonThrowEffectUpgrade3")] 		public CName BaseCommonThrowEffectUpgrade3 { get; set;}

		[RED("throwEffectSoil")] 		public CName ThrowEffectSoil { get; set;}

		[RED("throwEffectSoilUpgrade1")] 		public CName ThrowEffectSoilUpgrade1 { get; set;}

		[RED("throwEffectSoilUpgrade2")] 		public CName ThrowEffectSoilUpgrade2 { get; set;}

		[RED("throwEffectSoilUpgrade3")] 		public CName ThrowEffectSoilUpgrade3 { get; set;}

		[RED("throwEffectSPNoUpgrade")] 		public CName ThrowEffectSPNoUpgrade { get; set;}

		[RED("throwEffectSPUpgrade1")] 		public CName ThrowEffectSPUpgrade1 { get; set;}

		[RED("throwEffectSPUpgrade2")] 		public CName ThrowEffectSPUpgrade2 { get; set;}

		[RED("throwEffectSPUpgrade3")] 		public CName ThrowEffectSPUpgrade3 { get; set;}

		[RED("throwEffectDmgNoUpgrade")] 		public CName ThrowEffectDmgNoUpgrade { get; set;}

		[RED("throwEffectDmgUpgrade1")] 		public CName ThrowEffectDmgUpgrade1 { get; set;}

		[RED("throwEffectDmgUpgrade2")] 		public CName ThrowEffectDmgUpgrade2 { get; set;}

		[RED("throwEffectDmgUpgrade3")] 		public CName ThrowEffectDmgUpgrade3 { get; set;}

		[RED("throwEffectWater")] 		public CName ThrowEffectWater { get; set;}

		[RED("throwEffectWaterUpgrade1")] 		public CName ThrowEffectWaterUpgrade1 { get; set;}

		[RED("throwEffectWaterUpgrade2")] 		public CName ThrowEffectWaterUpgrade2 { get; set;}

		[RED("throwEffectWaterUpgrade3")] 		public CName ThrowEffectWaterUpgrade3 { get; set;}

		[RED("cameraShakeStrength")] 		public CFloat CameraShakeStrength { get; set;}

		public SAardEffects(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAardEffects(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}