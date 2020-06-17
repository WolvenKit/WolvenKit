using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskAddRemoveAbilityDef : IBehTreeTaskDefinition
	{
		[RED("abilityName")] 		public CName AbilityName { get; set;}

		[RED("allowMultiple")] 		public CBool AllowMultiple { get; set;}

		[RED("removeAbility")] 		public CBool RemoveAbility { get; set;}

		[RED("delayUntilInCameraFrame")] 		public CBool DelayUntilInCameraFrame { get; set;}

		[RED("onDeactivate")] 		public CBool OnDeactivate { get; set;}

		[RED("onAnimEventName")] 		public CName OnAnimEventName { get; set;}

		public BTTaskAddRemoveAbilityDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskAddRemoveAbilityDef(cr2w);

	}
}