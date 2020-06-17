using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIDynamicWanderParams : CAINpcWanderParams
	{
		[RED("dynamicWanderArea")] 		public EntityHandle DynamicWanderArea { get; set;}

		[RED("dynamicWanderIdleDuration")] 		public CFloat DynamicWanderIdleDuration { get; set;}

		[RED("dynamicWanderIdleChance")] 		public CFloat DynamicWanderIdleChance { get; set;}

		[RED("dynamicWanderMoveDuration")] 		public CFloat DynamicWanderMoveDuration { get; set;}

		[RED("dynamicWanderMoveChance")] 		public CFloat DynamicWanderMoveChance { get; set;}

		public CAIDynamicWanderParams(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CAIDynamicWanderParams(cr2w);

	}
}