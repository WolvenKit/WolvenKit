using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomEffectParams : CVariable
	{
		[Ordinal(0)] [RED("("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(0)] [RED("("creator")] 		public CHandle<CGameplayEntity> Creator { get; set;}

		[Ordinal(0)] [RED("("sourceName")] 		public CString SourceName { get; set;}

		[Ordinal(0)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("("effectValue")] 		public SAbilityAttributeValue EffectValue { get; set;}

		[Ordinal(0)] [RED("("customAbilityName")] 		public CName CustomAbilityName { get; set;}

		[Ordinal(0)] [RED("("customFXName")] 		public CName CustomFXName { get; set;}

		[Ordinal(0)] [RED("("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[Ordinal(0)] [RED("("customPowerStatValue")] 		public SAbilityAttributeValue CustomPowerStatValue { get; set;}

		[Ordinal(0)] [RED("("buffSpecificParams")] 		public CHandle<W3BuffCustomParams> BuffSpecificParams { get; set;}

		[Ordinal(0)] [RED("("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[Ordinal(0)] [RED("("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public SCustomEffectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCustomEffectParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}