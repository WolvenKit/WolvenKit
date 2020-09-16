using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageDjinnRage : IBehTreeTask
	{
		[Ordinal(1)] [RED("defaultFXName")] 		public CName DefaultFXName { get; set;}

		[Ordinal(2)] [RED("playFXOnAardHit")] 		public CName PlayFXOnAardHit { get; set;}

		[Ordinal(3)] [RED("playFXOnIgniHit")] 		public CName PlayFXOnIgniHit { get; set;}

		[Ordinal(4)] [RED("weakenedFXName")] 		public CName WeakenedFXName { get; set;}

		[Ordinal(5)] [RED("rageAbilityName")] 		public CName RageAbilityName { get; set;}

		[Ordinal(6)] [RED("weakenedAbilityName")] 		public CName WeakenedAbilityName { get; set;}

		[Ordinal(7)] [RED("calmDownCooldown")] 		public CFloat CalmDownCooldown { get; set;}

		[Ordinal(8)] [RED("removeWeakenedStateOnCounter")] 		public CBool RemoveWeakenedStateOnCounter { get; set;}

		[Ordinal(9)] [RED("m_isInYrden")] 		public CBool M_isInYrden { get; set;}

		[Ordinal(10)] [RED("m_inRageState")] 		public CBool M_inRageState { get; set;}

		[Ordinal(11)] [RED("m_inWeakenedState")] 		public CBool M_inWeakenedState { get; set;}

		[Ordinal(12)] [RED("m_enterRageTimeStamp")] 		public CFloat M_enterRageTimeStamp { get; set;}

		[Ordinal(13)] [RED("m_enterWeakendTimeStamp")] 		public CFloat M_enterWeakendTimeStamp { get; set;}

		public BTTaskManageDjinnRage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageDjinnRage(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}