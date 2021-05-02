using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EntitySlot : CVariable
	{
		[Ordinal(1)] [RED("wasIncluded")] 		public CBool WasIncluded { get; set;}

		[Ordinal(2)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(3)] [RED("componentName")] 		public CName ComponentName { get; set;}

		[Ordinal(4)] [RED("boneName")] 		public CName BoneName { get; set;}

		[Ordinal(5)] [RED("transform")] 		public EngineTransform Transform { get; set;}

		[Ordinal(6)] [RED("freePositionAxisX")] 		public CBool FreePositionAxisX { get; set;}

		[Ordinal(7)] [RED("freePositionAxisY")] 		public CBool FreePositionAxisY { get; set;}

		[Ordinal(8)] [RED("freePositionAxisZ")] 		public CBool FreePositionAxisZ { get; set;}

		[Ordinal(9)] [RED("freeRotation")] 		public CBool FreeRotation { get; set;}

		public EntitySlot(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EntitySlot(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}