using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventHitSound : CStorySceneEvent
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("actorAttacker")] 		public CName ActorAttacker { get; set;}

		[RED("soundAttackType")] 		public CName SoundAttackType { get; set;}

		[RED("actorAttackerWeaponSlot")] 		public CName ActorAttackerWeaponSlot { get; set;}

		[RED("actorAttackerWeaponName")] 		public CName ActorAttackerWeaponName { get; set;}

		public CStorySceneEventHitSound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventHitSound(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}