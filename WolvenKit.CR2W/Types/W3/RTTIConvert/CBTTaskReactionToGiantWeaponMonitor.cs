using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskReactionToGiantWeaponMonitor : IBehTreeTask
	{
		[Ordinal(0)] [RED("effectResourceName")] 		public CName EffectResourceName { get; set;}

		[Ordinal(0)] [RED("playFxOnEffectEntity")] 		public CName PlayFxOnEffectEntity { get; set;}

		[Ordinal(0)] [RED("spawnZOffset")] 		public CFloat SpawnZOffset { get; set;}

		[Ordinal(0)] [RED("effectEntity")] 		public CHandle<CEntityTemplate> EffectEntity { get; set;}

		[Ordinal(0)] [RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[Ordinal(0)] [RED("victimsArray", 2,0)] 		public CArray<CHandle<CActor>> VictimsArray { get; set;}

		[Ordinal(0)] [RED("actorEventReceived")] 		public CBool ActorEventReceived { get; set;}

		[Ordinal(0)] [RED("entityPos")] 		public Vector EntityPos { get; set;}

		[Ordinal(0)] [RED("entityRot")] 		public EulerAngles EntityRot { get; set;}

		public CBTTaskReactionToGiantWeaponMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToGiantWeaponMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}