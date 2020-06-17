using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTFinalStep : CMoveSTMove
	{
		[RED("ignoreGoalToleranceForFinalLocation")] 		public CBool IgnoreGoalToleranceForFinalLocation { get; set;}

		[RED("finalStepPositionVar")] 		public CName FinalStepPositionVar { get; set;}

		[RED("finalStepDistanceVar")] 		public CName FinalStepDistanceVar { get; set;}

		[RED("finalStepActiveVar")] 		public CName FinalStepActiveVar { get; set;}

		[RED("finalStepEvent")] 		public CName FinalStepEvent { get; set;}

		[RED("finalStepActivationNotification")] 		public CName FinalStepActivationNotification { get; set;}

		[RED("finalStepDeactivationNotification")] 		public CName FinalStepDeactivationNotification { get; set;}

		[RED("finalStepDeactivationNotificationTimeOut")] 		public CFloat FinalStepDeactivationNotificationTimeOut { get; set;}

		[RED("finalStepDistanceLimit")] 		public CFloat FinalStepDistanceLimit { get; set;}

		public CMoveSTFinalStep(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CMoveSTFinalStep(cr2w);

	}
}