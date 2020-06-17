using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAddEffectToTargetDef : IBehTreeTaskDefinition
	{
		[RED("onActivate")] 		public CBool OnActivate { get; set;}

		[RED("onEvent")] 		public CBool OnEvent { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("useLookAt")] 		public CBool UseLookAt { get; set;}

		[RED("applyEffectInterval")] 		public CFloat ApplyEffectInterval { get; set;}

		[RED("applyEffectForTime")] 		public CFloat ApplyEffectForTime { get; set;}

		[RED("applyEffectInRange")] 		public CFloat ApplyEffectInRange { get; set;}

		[RED("applyEffectInCone")] 		public CFloat ApplyEffectInCone { get; set;}

		[RED("eventName")] 		public CName EventName { get; set;}

		[RED("effectType")] 		public EEffectType EffectType { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("effectValue")] 		public CFloat EffectValue { get; set;}

		[RED("effectValuePerc")] 		public CFloat EffectValuePerc { get; set;}

		[RED("applyOnOwner")] 		public CBool ApplyOnOwner { get; set;}

		[RED("customFXName")] 		public CName CustomFXName { get; set;}

		[RED("breakQuen")] 		public CBool BreakQuen { get; set;}

		public CBTTaskAddEffectToTargetDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskAddEffectToTargetDef(cr2w);

	}
}