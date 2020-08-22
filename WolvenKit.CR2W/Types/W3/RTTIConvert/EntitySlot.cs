using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EntitySlot : CVariable
	{
		[RED("wasIncluded")] 		public CBool WasIncluded { get; set;}

		[RED("name")] 		public CName Name { get; set;}

		[RED("componentName")] 		public CName ComponentName { get; set;}

		[RED("boneName")] 		public CName BoneName { get; set;}

		[RED("transform")] 		public EngineTransform Transform { get; set;}

		[RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		public EntitySlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EntitySlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}