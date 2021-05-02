using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorMimicCloseEyesConstraint : IBehaviorMimicConstraint
	{
		[Ordinal(1)] [RED("eyeClosedTrack_Left")] 		public CInt32 EyeClosedTrack_Left { get; set;}

		[Ordinal(2)] [RED("eyeClosedTrack_Right")] 		public CInt32 EyeClosedTrack_Right { get; set;}

		[Ordinal(3)] [RED("bonesToOverride_Left", 2,0)] 		public CArray<CString> BonesToOverride_Left { get; set;}

		[Ordinal(4)] [RED("bonesToOverride_Right", 2,0)] 		public CArray<CString> BonesToOverride_Right { get; set;}

		public CBehaviorMimicCloseEyesConstraint(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorMimicCloseEyesConstraint(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}