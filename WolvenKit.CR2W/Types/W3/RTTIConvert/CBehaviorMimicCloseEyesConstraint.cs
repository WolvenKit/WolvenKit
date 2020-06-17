using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimicCloseEyesConstraint : IBehaviorMimicConstraint
	{
		[RED("eyeClosedTrack_Left")] 		public CInt32 EyeClosedTrack_Left { get; set;}

		[RED("eyeClosedTrack_Right")] 		public CInt32 EyeClosedTrack_Right { get; set;}

		[RED("bonesToOverride_Left", 2,0)] 		public CArray<CString> BonesToOverride_Left { get; set;}

		[RED("bonesToOverride_Right", 2,0)] 		public CArray<CString> BonesToOverride_Right { get; set;}

		public CBehaviorMimicCloseEyesConstraint(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorMimicCloseEyesConstraint(cr2w);

	}
}