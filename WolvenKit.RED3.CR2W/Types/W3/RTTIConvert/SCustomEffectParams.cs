using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCustomEffectParams : CVariable
	{
		[Ordinal(1)] [RED("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(2)] [RED("creator")] 		public CHandle<CGameplayEntity> Creator { get; set;}

		[Ordinal(3)] [RED("sourceName")] 		public CString SourceName { get; set;}

		[Ordinal(4)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(5)] [RED("effectValue")] 		public SAbilityAttributeValue EffectValue { get; set;}

		[Ordinal(6)] [RED("customAbilityName")] 		public CName CustomAbilityName { get; set;}

		[Ordinal(7)] [RED("customFXName")] 		public CName CustomFXName { get; set;}

		[Ordinal(8)] [RED("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[Ordinal(9)] [RED("customPowerStatValue")] 		public SAbilityAttributeValue CustomPowerStatValue { get; set;}

		[Ordinal(10)] [RED("buffSpecificParams")] 		public CHandle<W3BuffCustomParams> BuffSpecificParams { get; set;}

		[Ordinal(11)] [RED("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[Ordinal(12)] [RED("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public SCustomEffectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCustomEffectParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}