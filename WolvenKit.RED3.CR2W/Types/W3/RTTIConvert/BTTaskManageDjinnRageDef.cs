using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageDjinnRageDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("defaultFXName")] 		public CName DefaultFXName { get; set;}

		[Ordinal(2)] [RED("playFXOnAardHit")] 		public CName PlayFXOnAardHit { get; set;}

		[Ordinal(3)] [RED("playFXOnIgniHit")] 		public CName PlayFXOnIgniHit { get; set;}

		[Ordinal(4)] [RED("weakenedFXName")] 		public CName WeakenedFXName { get; set;}

		[Ordinal(5)] [RED("rageAbilityName")] 		public CName RageAbilityName { get; set;}

		[Ordinal(6)] [RED("weakenedAbilityName")] 		public CName WeakenedAbilityName { get; set;}

		[Ordinal(7)] [RED("calmDownCooldown")] 		public CFloat CalmDownCooldown { get; set;}

		[Ordinal(8)] [RED("removeWeakenedStateOnCounter")] 		public CBool RemoveWeakenedStateOnCounter { get; set;}

		public BTTaskManageDjinnRageDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageDjinnRageDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}