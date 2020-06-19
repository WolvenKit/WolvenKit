using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIWanderTree : CAIIdleTree
	{
		[RED("wanderMoveSpeed")] 		public CFloat WanderMoveSpeed { get; set;}

		[RED("wanderMoveType")] 		public CEnum<EMoveType> WanderMoveType { get; set;}

		[RED("wanderMaxDistance")] 		public CFloat WanderMaxDistance { get; set;}

		public CAIWanderTree(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIWanderTree(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}