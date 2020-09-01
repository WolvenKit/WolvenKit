using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAddEffectToTargetDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("("onActivate")] 		public CBool OnActivate { get; set;}

		[Ordinal(0)] [RED("("onEvent")] 		public CBool OnEvent { get; set;}

		[Ordinal(0)] [RED("("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(0)] [RED("("useLookAt")] 		public CBool UseLookAt { get; set;}

		[Ordinal(0)] [RED("("applyEffectInterval")] 		public CFloat ApplyEffectInterval { get; set;}

		[Ordinal(0)] [RED("("applyEffectForTime")] 		public CFloat ApplyEffectForTime { get; set;}

		[Ordinal(0)] [RED("("applyEffectInRange")] 		public CFloat ApplyEffectInRange { get; set;}

		[Ordinal(0)] [RED("("applyEffectInCone")] 		public CFloat ApplyEffectInCone { get; set;}

		[Ordinal(0)] [RED("("eventName")] 		public CName EventName { get; set;}

		[Ordinal(0)] [RED("("effectType")] 		public CEnum<EEffectType> EffectType { get; set;}

		[Ordinal(0)] [RED("("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(0)] [RED("("effectValue")] 		public CFloat EffectValue { get; set;}

		[Ordinal(0)] [RED("("effectValuePerc")] 		public CFloat EffectValuePerc { get; set;}

		[Ordinal(0)] [RED("("applyOnOwner")] 		public CBool ApplyOnOwner { get; set;}

		[Ordinal(0)] [RED("("customFXName")] 		public CName CustomFXName { get; set;}

		[Ordinal(0)] [RED("("breakQuen")] 		public CBool BreakQuen { get; set;}

		public CBTTaskAddEffectToTargetDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAddEffectToTargetDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}