using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SR4PlayerTargetingOut : CVariable
	{
		[Ordinal(1)] [RED("target")] 		public CHandle<CActor> Target { get; set;}

		[Ordinal(2)] [RED("result")] 		public CBool Result { get; set;}

		[Ordinal(3)] [RED("confirmNewTarget")] 		public CBool ConfirmNewTarget { get; set;}

		[Ordinal(4)] [RED("forceDisableUpdatePosition")] 		public CBool ForceDisableUpdatePosition { get; set;}

		public SR4PlayerTargetingOut(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SR4PlayerTargetingOut(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}