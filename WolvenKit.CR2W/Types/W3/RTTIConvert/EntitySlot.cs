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
		[Ordinal(0)] [RED("wasIncluded")] 		public CBool WasIncluded { get; set;}

		[Ordinal(0)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(0)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(0)] [RED("transform")] 		public EngineTransform Transform { get; set;}

		[Ordinal(0)] [RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[Ordinal(0)] [RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[Ordinal(0)] [RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[Ordinal(0)] [RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		public EntitySlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EntitySlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}