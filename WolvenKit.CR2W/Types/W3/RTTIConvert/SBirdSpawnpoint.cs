using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBirdSpawnpoint : CVariable
	{
		[Ordinal(0)] [RED("("isBirdSpawned")] 		public CBool IsBirdSpawned { get; set;}

		[Ordinal(0)] [RED("("isFlying")] 		public CBool IsFlying { get; set;}

		[Ordinal(0)] [RED("("entityId")] 		public CInt32 EntityId { get; set;}

		[Ordinal(0)] [RED("("entitySpawnTimestamp")] 		public CFloat EntitySpawnTimestamp { get; set;}

		[Ordinal(0)] [RED("("bird")] 		public CHandle<W3Bird> Bird { get; set;}

		[Ordinal(0)] [RED("("position")] 		public Vector Position { get; set;}

		[Ordinal(0)] [RED("("rotation")] 		public EulerAngles Rotation { get; set;}

		public SBirdSpawnpoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBirdSpawnpoint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}