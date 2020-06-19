using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SBirdSpawnpoint : CVariable
	{
		[RED("isBirdSpawned")] 		public CBool IsBirdSpawned { get; set;}

		[RED("isFlying")] 		public CBool IsFlying { get; set;}

		[RED("entityId")] 		public CInt32 EntityId { get; set;}

		[RED("entitySpawnTimestamp")] 		public CFloat EntitySpawnTimestamp { get; set;}

		[RED("bird")] 		public CHandle<W3Bird> Bird { get; set;}

		[RED("position")] 		public Vector Position { get; set;}

		[RED("rotation")] 		public EulerAngles Rotation { get; set;}

		public SBirdSpawnpoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SBirdSpawnpoint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}