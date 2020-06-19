using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskGuardDef : IBehTreeTaskDefinition
	{
		[RED("guardArea_var")] 		public CName GuardArea_var { get; set;}

		[RED("guardPursuitArea_var")] 		public CName GuardPursuitArea_var { get; set;}

		[RED("guardPursuitRange")] 		public CBehTreeValFloat GuardPursuitRange { get; set;}

		[RED("guardRetreatType")] 		public CHandle<CBTEnumMoveType> GuardRetreatType { get; set;}

		[RED("guardRetreatSpeed")] 		public CBehTreeValFloat GuardRetreatSpeed { get; set;}

		[RED("guardIntruderTestFrequency")] 		public CBehTreeValFloat GuardIntruderTestFrequency { get; set;}

		public CBTTaskGuardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskGuardDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}