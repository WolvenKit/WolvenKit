using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSpringDampValueNode : CBehaviorGraphValueBaseNode
	{
		[RED("factor")] 		public CFloat Factor { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("forceInputValueOnActivate")] 		public CBool ForceInputValueOnActivate { get; set;}

		public CBehaviorGraphSpringDampValueNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphSpringDampValueNode(cr2w);

	}
}