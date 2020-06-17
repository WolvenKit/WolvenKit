using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VirtualAnimationMotion : CVariable
	{
		[RED("startTime")] 		public CFloat StartTime { get; set;}

		[RED("endTime")] 		public CFloat EndTime { get; set;}

		[RED("blendIn")] 		public CFloat BlendIn { get; set;}

		[RED("blendOut")] 		public CFloat BlendOut { get; set;}

		public VirtualAnimationMotion(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new VirtualAnimationMotion(cr2w);

	}
}