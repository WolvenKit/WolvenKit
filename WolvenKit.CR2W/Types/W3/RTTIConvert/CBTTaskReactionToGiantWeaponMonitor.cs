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
		[RED("effectResourceName")] 		public CName EffectResourceName { get; set;}

		[RED("playFxOnEffectEntity")] 		public CName PlayFxOnEffectEntity { get; set;}

		[RED("spawnZOffset")] 		public CFloat SpawnZOffset { get; set;}

		[RED("effectEntity")] 		public CHandle<CEntityTemplate> EffectEntity { get; set;}

		[RED("victim")] 		public CHandle<CActor> Victim { get; set;}

		[RED("victimsArray", 2,0)] 		public CArray<CHandle<CActor>> VictimsArray { get; set;}

		[RED("actorEventReceived")] 		public CBool ActorEventReceived { get; set;}

		[RED("entityPos")] 		public Vector EntityPos { get; set;}

		[RED("entityRot")] 		public EulerAngles EntityRot { get; set;}

		public CBTTaskReactionToGiantWeaponMonitor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskReactionToGiantWeaponMonitor(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}