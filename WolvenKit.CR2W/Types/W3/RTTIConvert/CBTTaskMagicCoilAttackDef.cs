using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskMagicCoilAttackDef : CBTTaskAttackDef
	{
		[RED("fxNames", 2,0)] 		public CArray<CName> FxNames { get; set;}

		[RED("playFxInterval")] 		public CFloat PlayFxInterval { get; set;}

		[RED("shootProjectileRange")] 		public CFloat ShootProjectileRange { get; set;}

		[RED("shootProjectileInterval")] 		public CFloat ShootProjectileInterval { get; set;}

		[RED("deactivateAfter")] 		public CFloat DeactivateAfter { get; set;}

		[RED("setBehVarOnDeactivation")] 		public CName SetBehVarOnDeactivation { get; set;}

		[RED("setBehVarValueOnDeactivation")] 		public CFloat SetBehVarValueOnDeactivation { get; set;}

		[RED("useActorHeading")] 		public CBool UseActorHeading { get; set;}

		[RED("activateOnAnimEvent")] 		public CName ActivateOnAnimEvent { get; set;}

		[RED("projResourceName")] 		public CName ProjResourceName { get; set;}

		[RED("fxOnDamageInstigatedQuen")] 		public CName FxOnDamageInstigatedQuen { get; set;}

		public CBTTaskMagicCoilAttackDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskMagicCoilAttackDef(cr2w);

	}
}