using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3BeeSwarm : CGameplayEntity
	{
		[RED("damageVal")] 		public SAbilityAttributeValue DamageVal { get; set;}

		[RED("destroyEntAfter")] 		public CFloat DestroyEntAfter { get; set;}

		[RED("velocity")] 		public CFloat Velocity { get; set;}

		[RED("bIsEnabled")] 		public CBool BIsEnabled { get; set;}

		[RED("AIReactionRange")] 		public CFloat AIReactionRange { get; set;}

		[RED("ignoreNPCsFriendlyToPlayer")] 		public CBool IgnoreNPCsFriendlyToPlayer { get; set;}

		[RED("maxChaseDistance")] 		public CFloat MaxChaseDistance { get; set;}

		[RED("desiredTargetTag")] 		public CName DesiredTargetTag { get; set;}

		[RED("excludedEntitiesTags", 2,0)] 		public CArray<CName> ExcludedEntitiesTags { get; set;}

		[RED("factOnDestruction")] 		public CString FactOnDestruction { get; set;}

		public W3BeeSwarm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3BeeSwarm(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}