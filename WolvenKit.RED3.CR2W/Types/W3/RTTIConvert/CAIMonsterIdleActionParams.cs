using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterIdleActionParams : CAISubTreeParameters
	{
		[Ordinal(1)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(2)] [RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[Ordinal(3)] [RED("actionName")] 		public CName ActionName { get; set;}

		[Ordinal(4)] [RED("onlyOnGround")] 		public CBool OnlyOnGround { get; set;}

		public CAIMonsterIdleActionParams(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterIdleActionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}