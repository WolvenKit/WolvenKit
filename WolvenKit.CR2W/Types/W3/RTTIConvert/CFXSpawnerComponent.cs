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
		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("copyRotation")] 		public CBool CopyRotation { get; set;}

		[RED("attach")] 		public CBool Attach { get; set;}

		[RED("relativeRotation")] 		public EulerAngles RelativeRotation { get; set;}

		[RED("relativePosition")] 		public Vector RelativePosition { get; set;}

		[RED("parentSlotName")] 		public CName ParentSlotName { get; set;}

		[RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		[RED("percentage")] 		public CFloat Percentage { get; set;}

		public CFXSpawnerComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CFXSpawnerComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}