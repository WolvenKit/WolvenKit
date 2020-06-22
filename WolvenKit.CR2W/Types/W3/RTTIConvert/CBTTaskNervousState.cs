using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskNervousState : IBehTreeTask
	{
		[RED("dangerRadius")] 		public CFloat DangerRadius { get; set;}

		[RED("rearingChance")] 		public CFloat RearingChance { get; set;}

		[RED("kickChance")] 		public CFloat KickChance { get; set;}

		[RED("callFromQuestOnly")] 		public CBool CallFromQuestOnly { get; set;}

		[RED("force")] 		public CBool Force { get; set;}

		[RED("called")] 		public CBool Called { get; set;}

		[RED("dangerNode")] 		public CHandle<CNode> DangerNode { get; set;}

		public CBTTaskNervousState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskNervousState(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}