using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSendTutorialEventDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("onActivation")] 		public CBool OnActivation { get; set;}

		[Ordinal(2)] [RED("onDeactivation")] 		public CBool OnDeactivation { get; set;}

		[Ordinal(3)] [RED("guardSwordWarning")] 		public CBool GuardSwordWarning { get; set;}

		[Ordinal(4)] [RED("guardGeneralWarning")] 		public CBool GuardGeneralWarning { get; set;}

		[Ordinal(5)] [RED("guardLootingWarning")] 		public CBool GuardLootingWarning { get; set;}

		public CBTTaskSendTutorialEventDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSendTutorialEventDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}