using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ApplyEffectPhantomComponent : CPhantomComponent
	{
		[RED("effectToApply")] 		public EEffectType EffectToApply { get; set;}

		[RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[RED("requiredAbilities", 2,0)] 		public CArray<CName> RequiredAbilities { get; set;}

		[RED("onlyWhenAlive")] 		public CBool OnlyWhenAlive { get; set;}

		[RED("onlyToHostiles")] 		public CBool OnlyToHostiles { get; set;}

		[RED("onlyToTag")] 		public CName OnlyToTag { get; set;}

		[RED("ignoreIfHasEffect")] 		public CBool IgnoreIfHasEffect { get; set;}

		[RED("useCustomValue")] 		public CBool UseCustomValue { get; set;}

		[RED("customValue")] 		public SAbilityAttributeValue CustomValue { get; set;}

		[RED("forcedDamage")] 		public CFloat ForcedDamage { get; set;}

		[RED("minRelativeSpeed")] 		public CFloat MinRelativeSpeed { get; set;}

		[RED("decreasePlayerDmgBy")] 		public CFloat DecreasePlayerDmgBy { get; set;}

		[RED("playFXonCollisionEnter")] 		public CName PlayFXonCollisionEnter { get; set;}

		[RED("stopFXonCollisionExit")] 		public CBool StopFXonCollisionExit { get; set;}

		public W3ApplyEffectPhantomComponent(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new W3ApplyEffectPhantomComponent(cr2w);

	}
}