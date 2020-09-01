using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SEffectInitInfo : CVariable
	{
		[Ordinal(1)] [RED("("owner")] 		public CHandle<CGameplayEntity> Owner { get; set;}

		[Ordinal(2)] [RED("("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(3)] [RED("("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("("sourceName")] 		public CString SourceName { get; set;}

		[Ordinal(5)] [RED("("targetEffectManager")] 		public CHandle<W3EffectManager> TargetEffectManager { get; set;}

		[Ordinal(6)] [RED("("powerStatValue")] 		public SAbilityAttributeValue PowerStatValue { get; set;}

		[Ordinal(7)] [RED("("customEffectValue")] 		public SAbilityAttributeValue CustomEffectValue { get; set;}

		[Ordinal(8)] [RED("("customAbilityName")] 		public CName CustomAbilityName { get; set;}

		[Ordinal(9)] [RED("("customFXName")] 		public CName CustomFXName { get; set;}

		[Ordinal(10)] [RED("("isSignEffect")] 		public CBool IsSignEffect { get; set;}

		[Ordinal(11)] [RED("("vibratePadLowFreq")] 		public CFloat VibratePadLowFreq { get; set;}

		[Ordinal(12)] [RED("("vibratePadHighFreq")] 		public CFloat VibratePadHighFreq { get; set;}

		public SEffectInitInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SEffectInitInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}