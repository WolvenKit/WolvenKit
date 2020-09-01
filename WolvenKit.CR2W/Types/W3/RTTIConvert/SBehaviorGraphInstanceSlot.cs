using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphInstanceSlot : CVariable
	{
		[Ordinal(1)] [RED("instanceName")] 		public CName InstanceName { get; set;}

		[Ordinal(2)] [RED("graph")] 		public CHandle<CBehaviorGraph> Graph { get; set;}

		[Ordinal(3)] [RED("alwaysOnTopOfStack")] 		public CBool AlwaysOnTopOfStack { get; set;}

		public SBehaviorGraphInstanceSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBehaviorGraphInstanceSlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}