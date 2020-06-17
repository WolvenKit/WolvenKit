using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBehaviorGraphInstanceSlot : CVariable
	{
		[RED("instanceName")] 		public CName InstanceName { get; set;}

		[RED("graph")] 		public CHandle<CBehaviorGraph> Graph { get; set;}

		[RED("alwaysOnTopOfStack")] 		public CBool AlwaysOnTopOfStack { get; set;}

		public SBehaviorGraphInstanceSlot(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SBehaviorGraphInstanceSlot(cr2w);

	}
}