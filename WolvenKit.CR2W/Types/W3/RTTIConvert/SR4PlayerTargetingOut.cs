using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingOut : CVariable
	{
		[RED("target")] 		public CHandle<CActor> Target { get; set;}

		[RED("result")] 		public CBool Result { get; set;}

		[RED("confirmNewTarget")] 		public CBool ConfirmNewTarget { get; set;}

		[RED("forceDisableUpdatePosition")] 		public CBool ForceDisableUpdatePosition { get; set;}

		public SR4PlayerTargetingOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingOut(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}