using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphMimicBlinkControllerNode_Setter : CBehaviorGraphMimicBlinkControllerNode
	{
		[RED("blinkValueThr")] 		public CFloat BlinkValueThr { get; set;}

		[RED("blinkCooldown")] 		public CFloat BlinkCooldown { get; set;}

		public CBehaviorGraphMimicBlinkControllerNode_Setter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphMimicBlinkControllerNode_Setter(cr2w);

	}
}