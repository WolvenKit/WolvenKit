using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskHasAbility : IBehTreeTask
	{
		[Ordinal(1)] [RED("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(2)] [RED("behVariableName")] 		public CName BehVariableName { get; set;}

		[Ordinal(3)] [RED("behVariableActivateValue")] 		public CFloat BehVariableActivateValue { get; set;}

		[Ordinal(4)] [RED("behVariableDeactivateValue")] 		public CFloat BehVariableDeactivateValue { get; set;}

		[Ordinal(5)] [RED("failAnim")] 		public CBool FailAnim { get; set;}

		[Ordinal(6)] [RED("turnOffOnDeactivate")] 		public CBool TurnOffOnDeactivate { get; set;}

		[Ordinal(7)] [RED("turnedOff")] 		public CBool TurnedOff { get; set;}

		public CBTTaskHasAbility(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskHasAbility(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}