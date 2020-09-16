using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicCoilAttackDef : CBTTaskAttackDef
	{
		[Ordinal(1)] [RED("fxNames", 2,0)] 		public CArray<CName> FxNames { get; set;}

		[Ordinal(2)] [RED("playFxInterval")] 		public CFloat PlayFxInterval { get; set;}

		[Ordinal(3)] [RED("shootProjectileRange")] 		public CFloat ShootProjectileRange { get; set;}

		[Ordinal(4)] [RED("shootProjectileInterval")] 		public CFloat ShootProjectileInterval { get; set;}

		[Ordinal(5)] [RED("deactivateAfter")] 		public CFloat DeactivateAfter { get; set;}

		[Ordinal(6)] [RED("setBehVarOnDeactivation")] 		public CName SetBehVarOnDeactivation { get; set;}

		[Ordinal(7)] [RED("setBehVarValueOnDeactivation")] 		public CFloat SetBehVarValueOnDeactivation { get; set;}

		[Ordinal(8)] [RED("useActorHeading")] 		public CBool UseActorHeading { get; set;}

		[Ordinal(9)] [RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[Ordinal(10)] [RED("projResourceName")] 		public CName ProjResourceName { get; set;}

		[Ordinal(11)] [RED("fxOnDamageInstigatedQuen")] 		public CName FxOnDamageInstigatedQuen { get; set;}

		public CBTTaskMagicCoilAttackDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskMagicCoilAttackDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}