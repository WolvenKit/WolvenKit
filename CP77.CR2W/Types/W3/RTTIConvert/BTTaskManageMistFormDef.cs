using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class BTTaskManageMistFormDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("enableOnActivate")] 		public CBool EnableOnActivate { get; set;}

		[Ordinal(2)] [RED("enableOnMain")] 		public CBool EnableOnMain { get; set;}

		[Ordinal(3)] [RED("disableOnDeactivate")] 		public CBool DisableOnDeactivate { get; set;}

		[Ordinal(4)] [RED("affectVisibility")] 		public CBool AffectVisibility { get; set;}

		[Ordinal(5)] [RED("affectGameplayVisibility")] 		public CBool AffectGameplayVisibility { get; set;}

		[Ordinal(6)] [RED("affectCollision")] 		public CBool AffectCollision { get; set;}

		[Ordinal(7)] [RED("affectHitAnims")] 		public CBool AffectHitAnims { get; set;}

		[Ordinal(8)] [RED("affectImmortality")] 		public CBool AffectImmortality { get; set;}

		[Ordinal(9)] [RED("delayExecutionInMain")] 		public CFloat DelayExecutionInMain { get; set;}

		[Ordinal(10)] [RED("appearanceOnActivate")] 		public CName AppearanceOnActivate { get; set;}

		[Ordinal(11)] [RED("appearanceOnMain")] 		public CName AppearanceOnMain { get; set;}

		[Ordinal(12)] [RED("restoreAppearanceOnDeactivate")] 		public CBool RestoreAppearanceOnDeactivate { get; set;}

		[Ordinal(13)] [RED("appearanceOnDeactivate")] 		public CName AppearanceOnDeactivate { get; set;}

		public BTTaskManageMistFormDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new BTTaskManageMistFormDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}