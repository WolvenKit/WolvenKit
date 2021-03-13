using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAddRemoveAbilityDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("abilityName")] 		public CName AbilityName { get; set;}

		[Ordinal(2)] [RED("allowMultiple")] 		public CBool AllowMultiple { get; set;}

		[Ordinal(3)] [RED("removeAbility")] 		public CBool RemoveAbility { get; set;}

		[Ordinal(4)] [RED("delayUntilInCameraFrame")] 		public CBool DelayUntilInCameraFrame { get; set;}

		[Ordinal(5)] [RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[Ordinal(6)] [RED("onAnimEventName")] 		public CName OnAnimEventName { get; set;}

		public BTTaskAddRemoveAbilityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskAddRemoveAbilityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}