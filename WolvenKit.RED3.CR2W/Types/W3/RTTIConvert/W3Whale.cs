using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Whale : CGameplayEntity
	{
		[Ordinal(1)] [RED("whaleArea")] 		public CHandle<W3WhaleArea> WhaleArea { get; set;}

		[Ordinal(2)] [RED("destroyTime")] 		public CFloat DestroyTime { get; set;}

		[Ordinal(3)] [RED("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[Ordinal(4)] [RED("canBeDestroyed")] 		public CBool CanBeDestroyed { get; set;}

		[Ordinal(5)] [RED("spawnPosition")] 		public Vector SpawnPosition { get; set;}

		[Ordinal(6)] [RED("spawnRotation")] 		public EulerAngles SpawnRotation { get; set;}

		public W3Whale(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}