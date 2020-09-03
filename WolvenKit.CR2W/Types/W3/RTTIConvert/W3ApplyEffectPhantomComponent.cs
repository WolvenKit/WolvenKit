using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3ApplyEffectPhantomComponent : CPhantomComponent
	{
		[Ordinal(1)] [RED("effectToApply")] 		public CEnum<EEffectType> EffectToApply { get; set;}

		[Ordinal(2)] [RED("effectDuration")] 		public CFloat EffectDuration { get; set;}

		[Ordinal(3)] [RED("requiredAbilities", 2,0)] 		public CArray<CName> RequiredAbilities { get; set;}

		[Ordinal(4)] [RED("onlyWhenAlive")] 		public CBool OnlyWhenAlive { get; set;}

		[Ordinal(5)] [RED("onlyToHostiles")] 		public CBool OnlyToHostiles { get; set;}

		[Ordinal(6)] [RED("onlyToTag")] 		public CName OnlyToTag { get; set;}

		[Ordinal(7)] [RED("ignoreIfHasEffect")] 		public CBool IgnoreIfHasEffect { get; set;}

		[Ordinal(8)] [RED("useCustomValue")] 		public CBool UseCustomValue { get; set;}

		[Ordinal(9)] [RED("customValue")] 		public SAbilityAttributeValue CustomValue { get; set;}

		[Ordinal(10)] [RED("forcedDamage")] 		public CFloat ForcedDamage { get; set;}

		[Ordinal(11)] [RED("minRelativeSpeed")] 		public CFloat MinRelativeSpeed { get; set;}

		[Ordinal(12)] [RED("decreasePlayerDmgBy")] 		public CFloat DecreasePlayerDmgBy { get; set;}

		[Ordinal(13)] [RED("playFXonCollisionEnter")] 		public CName PlayFXonCollisionEnter { get; set;}

		[Ordinal(14)] [RED("stopFXonCollisionExit")] 		public CBool StopFXonCollisionExit { get; set;}

		[Ordinal(15)] [RED("objectAttached")] 		public CBool ObjectAttached { get; set;}

		public W3ApplyEffectPhantomComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3ApplyEffectPhantomComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}