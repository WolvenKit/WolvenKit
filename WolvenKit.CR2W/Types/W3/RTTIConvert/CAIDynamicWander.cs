using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIDynamicWander : CAIWanderTree
	{
		[Ordinal(0)] [RED("params")] 		public CHandle<CAIDynamicWanderParams> Params { get; set;}

		[Ordinal(0)] [RED("dynamicWanderArea")] 		public EntityHandle DynamicWanderArea { get; set;}

		[Ordinal(0)] [RED("dynamicWanderUseGuardArea")] 		public CBool DynamicWanderUseGuardArea { get; set;}

		[Ordinal(0)] [RED("dynamicWanderIdleDuration")] 		public CFloat DynamicWanderIdleDuration { get; set;}

		[Ordinal(0)] [RED("dynamicWanderIdleChance")] 		public CFloat DynamicWanderIdleChance { get; set;}

		[Ordinal(0)] [RED("dynamicWanderMoveDuration")] 		public CFloat DynamicWanderMoveDuration { get; set;}

		[Ordinal(0)] [RED("dynamicWanderMoveChance")] 		public CFloat DynamicWanderMoveChance { get; set;}

		[Ordinal(0)] [RED("dynamicWanderMinimalDistance")] 		public CFloat DynamicWanderMinimalDistance { get; set;}

		public CAIDynamicWander(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIDynamicWander(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}