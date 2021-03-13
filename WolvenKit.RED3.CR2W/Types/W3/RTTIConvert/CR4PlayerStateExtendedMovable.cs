using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateExtendedMovable : CPlayerStateMovable
	{
		[Ordinal(1)] [RED("parentMAC")] 		public CHandle<CMovingPhysicalAgentComponent> ParentMAC { get; set;}

		[Ordinal(2)] [RED("currentStateName")] 		public CName CurrentStateName { get; set;}

		[Ordinal(3)] [RED("cameraChanneledSignEnabled")] 		public CBool CameraChanneledSignEnabled { get; set;}

		[Ordinal(4)] [RED("m_shouldEnableAutoRotation")] 		public CBool M_shouldEnableAutoRotation { get; set;}

		[Ordinal(5)] [RED("interiorCameraDesiredPositionMult")] 		public CFloat InteriorCameraDesiredPositionMult { get; set;}

		public CR4PlayerStateExtendedMovable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateExtendedMovable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}