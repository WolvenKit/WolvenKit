using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SUITutorial : CVariable
	{
		[Ordinal(1)] [RED("menuName")] 		public CName MenuName { get; set;}

		[Ordinal(2)] [RED("tutorialStateName")] 		public CName TutorialStateName { get; set;}

		[Ordinal(3)] [RED("triggerCondition")] 		public CEnum<EUITutorialTriggerCondition> TriggerCondition { get; set;}

		[Ordinal(4)] [RED("requiredGameplayFactName")] 		public CString RequiredGameplayFactName { get; set;}

		[Ordinal(5)] [RED("requiredGameplayFactValueInt")] 		public CInt32 RequiredGameplayFactValueInt { get; set;}

		[Ordinal(6)] [RED("requiredGameplayFactComparator")] 		public CEnum<ECompareOp> RequiredGameplayFactComparator { get; set;}

		[Ordinal(7)] [RED("requiredGameplayFactName2")] 		public CString RequiredGameplayFactName2 { get; set;}

		[Ordinal(8)] [RED("requiredGameplayFactValueInt2")] 		public CInt32 RequiredGameplayFactValueInt2 { get; set;}

		[Ordinal(9)] [RED("requiredGameplayFactComparator2")] 		public CEnum<ECompareOp> RequiredGameplayFactComparator2 { get; set;}

		[Ordinal(10)] [RED("priority")] 		public CInt32 Priority { get; set;}

		[Ordinal(11)] [RED("abortOnMenuClose")] 		public CBool AbortOnMenuClose { get; set;}

		[Ordinal(12)] [RED("sourceName")] 		public CString SourceName { get; set;}

		public SUITutorial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SUITutorial(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}