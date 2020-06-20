using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageDjinnRageDef : IBehTreeTaskDefinition
	{
		[RED("defaultFXName")] 		public CName DefaultFXName { get; set;}

		[RED("playFXOnAardHit")] 		public CName PlayFXOnAardHit { get; set;}

		[RED("playFXOnIgniHit")] 		public CName PlayFXOnIgniHit { get; set;}

		[RED("weakenedFXName")] 		public CName WeakenedFXName { get; set;}

		[RED("rageAbilityName")] 		public CName RageAbilityName { get; set;}

		[RED("weakenedAbilityName")] 		public CName WeakenedAbilityName { get; set;}

		[RED("calmDownCooldown")] 		public CFloat CalmDownCooldown { get; set;}

		[RED("removeWeakenedStateOnCounter")] 		public CBool RemoveWeakenedStateOnCounter { get; set;}

		public BTTaskManageDjinnRageDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageDjinnRageDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}