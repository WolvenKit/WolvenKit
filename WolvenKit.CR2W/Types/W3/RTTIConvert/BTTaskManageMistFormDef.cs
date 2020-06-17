using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageMistFormDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("enableOnActivate")] 		public CBool EnableOnActivate { get; set;}

		[RED("enableOnMain")] 		public CBool EnableOnMain { get; set;}

		[RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[RED("affectVisibility")] 		public CBool AffectVisibility { get; set;}

		[RED("affectGameplayVisibility")] 		public CBool AffectGameplayVisibility { get; set;}

		[RED("affectCollision")] 		public CBool AffectCollision { get; set;}

		[RED("affectHitAnims")] 		public CBool AffectHitAnims { get; set;}

		[RED("affectImmortality")] 		public CBool AffectImmortality { get; set;}

		[RED("delayExecutionInMain")] 		public CFloat DelayExecutionInMain { get; set;}

		[RED("appearanceOnActivate")] 		public CName AppearanceOnActivate { get; set;}

		[RED("appearanceOnMain")] 		public CName AppearanceOnMain { get; set;}

		[RED("restoreAppearanceOnDeactivate")] 		public CBool RestoreAppearanceOnDeactivate { get; set;}

		[RED("appearanceOnDeactivate")] 		public CName AppearanceOnDeactivate { get; set;}

		public BTTaskManageMistFormDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new BTTaskManageMistFormDef(cr2w);

	}
}