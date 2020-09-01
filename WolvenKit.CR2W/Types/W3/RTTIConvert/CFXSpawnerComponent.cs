using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CFXSpawnerComponent : IFXSpawner
	{
		[Ordinal(0)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(0)] [RED("copyRotation")] 		public CBool CopyRotation { get; set;}

		[Ordinal(0)] [RED("attach")] 		public CBool Attach { get; set;}

		[Ordinal(0)] [RED("relativeRotation")] 		public EulerAngles RelativeRotation { get; set;}

		[Ordinal(0)] [RED("relativePosition")] 		public Vector RelativePosition { get; set;}

		[Ordinal(0)] [RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[Ordinal(0)] [RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[Ordinal(0)] [RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[Ordinal(0)] [RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[Ordinal(0)] [RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		[Ordinal(0)] [RED("percentage")] 		public CFloat Percentage { get; set;}

		public CFXSpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXSpawnerComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}