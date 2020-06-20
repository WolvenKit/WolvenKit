using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SComboAttackCallbackInfo : CVariable
	{
		[RED("outDirection")] 		public CEnum<EAttackDirection> OutDirection { get; set;}

		[RED("outDistance")] 		public CEnum<EAttackDistance> OutDistance { get; set;}

		[RED("outAttackType")] 		public CEnum<EComboAttackType> OutAttackType { get; set;}

		[RED("inAspectName")] 		public CName InAspectName { get; set;}

		[RED("inGlobalAttackCounter")] 		public CInt32 InGlobalAttackCounter { get; set;}

		[RED("inStringAttackCounter")] 		public CInt32 InStringAttackCounter { get; set;}

		[RED("inAttackId")] 		public CInt32 InAttackId { get; set;}

		[RED("prevDirAttack")] 		public CBool PrevDirAttack { get; set;}

		[RED("outRotateToEnemyAngle")] 		public CFloat OutRotateToEnemyAngle { get; set;}

		[RED("outSlideToPosition")] 		public Vector OutSlideToPosition { get; set;}

		[RED("outShouldTranslate")] 		public CBool OutShouldTranslate { get; set;}

		[RED("outShouldRotate")] 		public CBool OutShouldRotate { get; set;}

		[RED("outLeftString")] 		public CBool OutLeftString { get; set;}

		public SComboAttackCallbackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SComboAttackCallbackInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}