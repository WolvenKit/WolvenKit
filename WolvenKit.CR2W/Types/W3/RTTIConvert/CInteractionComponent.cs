using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInteractionComponent : CInteractionAreaComponent
	{
		[Ordinal(0)] [RED("actionName")] 		public CString ActionName { get; set;}

		[Ordinal(0)] [RED("checkCameraVisibility")] 		public CBool CheckCameraVisibility { get; set;}

		[Ordinal(0)] [RED("reportToScript")] 		public CBool ReportToScript { get; set;}

		[Ordinal(0)] [RED("isEnabledInCombat")] 		public CBool IsEnabledInCombat { get; set;}

		[Ordinal(0)] [RED("shouldIgnoreLocks")] 		public CBool ShouldIgnoreLocks { get; set;}

		[Ordinal(0)] [RED("isEnabledOnHorse")] 		public CBool IsEnabledOnHorse { get; set;}

		[Ordinal(0)] [RED("aimVector")] 		public Vector AimVector { get; set;}

		[Ordinal(0)] [RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[Ordinal(0)] [RED("iconOffsetSlotName")] 		public CName IconOffsetSlotName { get; set;}

		public CInteractionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CInteractionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}