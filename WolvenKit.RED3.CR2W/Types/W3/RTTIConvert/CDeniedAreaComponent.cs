using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDeniedAreaComponent : CAreaComponent
	{
		[Ordinal(1)] [RED("collisionType")] 		public CEnum<EPathLibCollision> CollisionType { get; set;}

		[Ordinal(2)] [RED("isEnabled")] 		public CBool IsEnabled { get; set;}

		[Ordinal(3)] [RED("canBeDisabled")] 		public CBool CanBeDisabled { get; set;}

		public CDeniedAreaComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDeniedAreaComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}