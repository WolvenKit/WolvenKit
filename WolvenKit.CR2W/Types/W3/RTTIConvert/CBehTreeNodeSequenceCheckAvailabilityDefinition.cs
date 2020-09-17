using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehTreeNodeSequenceCheckAvailabilityDefinition : CBehTreeNodeSequenceDefinition
	{
		[Ordinal(1)] [RED("continueSequenceOnChildFailure")] 		public CBool ContinueSequenceOnChildFailure { get; set;}

		[Ordinal(2)] [RED("updateCheckIsAvailable")] 		public CBool UpdateCheckIsAvailable { get; set;}

		[Ordinal(3)] [RED("updateCheckIsAvailFreq")] 		public CFloat UpdateCheckIsAvailFreq { get; set;}

		public CBehTreeNodeSequenceCheckAvailabilityDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehTreeNodeSequenceCheckAvailabilityDefinition(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}