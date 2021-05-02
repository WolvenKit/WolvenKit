using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXSpawnerComponent : IFXSpawner
	{
		[Ordinal(1)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(2)] [RED("copyRotation")] 		public CBool CopyRotation { get; set;}

		[Ordinal(3)] [RED("attach")] 		public CBool Attach { get; set;}

		[Ordinal(4)] [RED("relativeRotation")] 		public EulerAngles RelativeRotation { get; set;}

		[Ordinal(5)] [RED("relativePosition")] 		public Vector RelativePosition { get; set;}

		[Ordinal(6)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(7)] [RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[Ordinal(8)] [RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[Ordinal(9)] [RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[Ordinal(10)] [RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		[Ordinal(11)] [RED("percentage")] 		public CFloat Percentage { get; set;}

		public CFXSpawnerComponent(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXSpawnerComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}