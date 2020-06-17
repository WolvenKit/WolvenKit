using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4EntityExternalAppearanceDLCMounter : IGameplayDLCMounter
	{
		[RED("entityTemplatePaths", 2,0)] 		public CArray<CString> EntityTemplatePaths { get; set;}

		[RED("entityExternalAppearances", 2,0)] 		public CArray<CPtr<CR4EntityExternalAppearanceDLC>> EntityExternalAppearances { get; set;}

		public CR4EntityExternalAppearanceDLCMounter(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CR4EntityExternalAppearanceDLCMounter(cr2w);

	}
}