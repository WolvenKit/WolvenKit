using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTCondHorsePerformingActionDef : IBehTreeHorseConditionalTaskDefinition
	{
		[RED("mounting")] 		public CBool Mounting { get; set;}

		[RED("dismounting")] 		public CBool Dismounting { get; set;}

		[RED("inAir")] 		public CBool InAir { get; set;}

		public CBTCondHorsePerformingActionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTCondHorsePerformingActionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}