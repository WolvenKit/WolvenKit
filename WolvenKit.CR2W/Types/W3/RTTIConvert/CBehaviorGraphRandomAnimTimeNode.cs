using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRandomAnimTimeNode : CBehaviorGraphBaseNode
	{
		[RED("animSpeedMin")] 		public CFloat AnimSpeedMin { get; set;}

		[RED("animSpeedMax")] 		public CFloat AnimSpeedMax { get; set;}

		[RED("animStartTimeOffset")] 		public CFloat AnimStartTimeOffset { get; set;}

		[RED("animStartTimePrecent")] 		public CFloat AnimStartTimePrecent { get; set;}

		public CBehaviorGraphRandomAnimTimeNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRandomAnimTimeNode(cr2w);

	}
}