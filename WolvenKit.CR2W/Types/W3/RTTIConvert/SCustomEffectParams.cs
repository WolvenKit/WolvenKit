using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomEffectParams : CVariable
	{
		[RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[RED("creator")] 		public CHandle<CGameplayEntity> Creator { get; set;}

		[RED("sourceName")] 		public CString SourceName { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("effectValue")] 		public SAbilityAttributeValue EffectValue { get; set;}

		[RED("customAbilityName")] 		public CName CustomAbilityName { get; set;}

		[RED("customFXName")] 		public CName CustomFXName { get; set;}

		[RED("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[RED("customPowerStatValue")] 		public SAbilityAttributeValue CustomPowerStatValue { get; set;}

		[RED("buffSpecificParams")] 		public CHandle<W3BuffCustomParams> BuffSpecificParams { get; set;}

		[RED("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[RED("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public SCustomEffectParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SCustomEffectParams(cr2w);

	}
}