using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIDynamicWander : CAIWanderTree
	{
		[Ordinal(1)] [RED("params")] 		public CHandle<CAIDynamicWanderParams> Params { get; set;}

		[Ordinal(2)] [RED("dynamicWanderArea")] 		public EntityHandle DynamicWanderArea { get; set;}

		[Ordinal(3)] [RED("dynamicWanderUseGuardArea")] 		public CBool DynamicWanderUseGuardArea { get; set;}

		[Ordinal(4)] [RED("dynamicWanderIdleDuration")] 		public CFloat DynamicWanderIdleDuration { get; set;}

		[Ordinal(5)] [RED("dynamicWanderIdleChance")] 		public CFloat DynamicWanderIdleChance { get; set;}

		[Ordinal(6)] [RED("dynamicWanderMoveDuration")] 		public CFloat DynamicWanderMoveDuration { get; set;}

		[Ordinal(7)] [RED("dynamicWanderMoveChance")] 		public CFloat DynamicWanderMoveChance { get; set;}

		[Ordinal(8)] [RED("dynamicWanderMinimalDistance")] 		public CFloat DynamicWanderMinimalDistance { get; set;}

		public CAIDynamicWander(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIDynamicWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}