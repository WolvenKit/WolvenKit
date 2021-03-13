using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CInteractionComponent : CInteractionAreaComponent
	{
		[Ordinal(1)] [RED("actionName")] 		public CString ActionName { get; set;}

		[Ordinal(2)] [RED("checkCameraVisibility")] 		public CBool CheckCameraVisibility { get; set;}

		[Ordinal(3)] [RED("reportToScript")] 		public CBool ReportToScript { get; set;}

		[Ordinal(4)] [RED("isEnabledInCombat")] 		public CBool IsEnabledInCombat { get; set;}

		[Ordinal(5)] [RED("shouldIgnoreLocks")] 		public CBool ShouldIgnoreLocks { get; set;}

		[Ordinal(6)] [RED("isEnabledOnHorse")] 		public CBool IsEnabledOnHorse { get; set;}

		[Ordinal(7)] [RED("aimVector")] 		public Vector AimVector { get; set;}

		[Ordinal(8)] [RED("iconOffset")] 		public Vector IconOffset { get; set;}

		[Ordinal(9)] [RED("iconOffsetSlotName")] 		public CName IconOffsetSlotName { get; set;}

		public CInteractionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CInteractionComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}