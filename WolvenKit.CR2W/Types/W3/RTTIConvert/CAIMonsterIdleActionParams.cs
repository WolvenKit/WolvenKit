using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIMonsterIdleActionParams : CAISubTreeParameters
	{
		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("loopTime")] 		public CFloat LoopTime { get; set;}

		[RED("actionName")] 		public CName ActionName { get; set;}

		[RED("onlyOnGround")] 		public CBool OnlyOnGround { get; set;}

		public CAIMonsterIdleActionParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIMonsterIdleActionParams(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}