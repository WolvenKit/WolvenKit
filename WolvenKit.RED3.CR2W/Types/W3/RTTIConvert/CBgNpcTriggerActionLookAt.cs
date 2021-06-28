using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBgNpcTriggerActionLookAt : IBgNpcTriggerAction
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<EReactionLookAtType> Type { get; set;}

		[Ordinal(2)] [RED("onlyPlayer")] 		public CBool OnlyPlayer { get; set;}

		[Ordinal(3)] [RED("maxDelay")] 		public CFloat MaxDelay { get; set;}

		public CBgNpcTriggerActionLookAt(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}