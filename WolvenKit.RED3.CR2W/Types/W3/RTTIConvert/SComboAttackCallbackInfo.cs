using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SComboAttackCallbackInfo : CVariable
	{
		[Ordinal(1)] [RED("outDirection")] 		public CEnum<EAttackDirection> OutDirection { get; set;}

		[Ordinal(2)] [RED("outDistance")] 		public CEnum<EAttackDistance> OutDistance { get; set;}

		[Ordinal(3)] [RED("outAttackType")] 		public CEnum<EComboAttackType> OutAttackType { get; set;}

		[Ordinal(4)] [RED("inAspectName")] 		public CName InAspectName { get; set;}

		[Ordinal(5)] [RED("inGlobalAttackCounter")] 		public CInt32 InGlobalAttackCounter { get; set;}

		[Ordinal(6)] [RED("inStringAttackCounter")] 		public CInt32 InStringAttackCounter { get; set;}

		[Ordinal(7)] [RED("inAttackId")] 		public CInt32 InAttackId { get; set;}

		[Ordinal(8)] [RED("prevDirAttack")] 		public CBool PrevDirAttack { get; set;}

		[Ordinal(9)] [RED("outRotateToEnemyAngle")] 		public CFloat OutRotateToEnemyAngle { get; set;}

		[Ordinal(10)] [RED("outSlideToPosition")] 		public Vector OutSlideToPosition { get; set;}

		[Ordinal(11)] [RED("outShouldTranslate")] 		public CBool OutShouldTranslate { get; set;}

		[Ordinal(12)] [RED("outShouldRotate")] 		public CBool OutShouldRotate { get; set;}

		[Ordinal(13)] [RED("outLeftString")] 		public CBool OutLeftString { get; set;}

		public SComboAttackCallbackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SComboAttackCallbackInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}