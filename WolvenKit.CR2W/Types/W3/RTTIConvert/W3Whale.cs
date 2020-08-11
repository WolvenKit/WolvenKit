using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Whale : CGameplayEntity
	{
		[RED("whaleArea")] 		public CHandle<W3WhaleArea> WhaleArea { get; set;}

		[RED("destroyTime")] 		public CFloat DestroyTime { get; set;}

		[RED("alwaysSpawned")] 		public CBool AlwaysSpawned { get; set;}

		[RED("canBeDestroyed")] 		public CBool CanBeDestroyed { get; set;}

		[RED("spawnPosition")] 		public Vector SpawnPosition { get; set;}

		[RED("spawnRotation")] 		public EulerAngles SpawnRotation { get; set;}

		public W3Whale(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Whale(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}