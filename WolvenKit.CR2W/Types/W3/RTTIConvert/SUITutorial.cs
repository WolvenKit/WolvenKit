using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SUITutorial : CVariable
	{
		[RED("menuName")] 		public CName MenuName { get; set;}

		[RED("tutorialStateName")] 		public CName TutorialStateName { get; set;}

		[RED("triggerCondition")] 		public CEnum<EUITutorialTriggerCondition> TriggerCondition { get; set;}

		[RED("requiredGameplayFactName")] 		public CString RequiredGameplayFactName { get; set;}

		[RED("requiredGameplayFactValueInt")] 		public CInt32 RequiredGameplayFactValueInt { get; set;}

		[RED("requiredGameplayFactComparator")] 		public CEnum<ECompareOp> RequiredGameplayFactComparator { get; set;}

		[RED("requiredGameplayFactName2")] 		public CString RequiredGameplayFactName2 { get; set;}

		[RED("requiredGameplayFactValueInt2")] 		public CInt32 RequiredGameplayFactValueInt2 { get; set;}

		[RED("requiredGameplayFactComparator2")] 		public CEnum<ECompareOp> RequiredGameplayFactComparator2 { get; set;}

		[RED("priority")] 		public CInt32 Priority { get; set;}

		[RED("abortOnMenuClose")] 		public CBool AbortOnMenuClose { get; set;}

		[RED("sourceName")] 		public CString SourceName { get; set;}

		public SUITutorial(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SUITutorial(cr2w);

	}
}