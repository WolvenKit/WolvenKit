using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4PlayerStateExtendedMovable : CPlayerStateMovable
	{
		[RED("parentMAC")] 		public CHandle<CMovingPhysicalAgentComponent> ParentMAC { get; set;}

		[RED("currentStateName")] 		public CName CurrentStateName { get; set;}

		[RED("cameraChanneledSignEnabled")] 		public CBool CameraChanneledSignEnabled { get; set;}

		[RED("m_shouldEnableAutoRotation")] 		public CBool M_shouldEnableAutoRotation { get; set;}

		[RED("interiorCameraDesiredPositionMult")] 		public CFloat InteriorCameraDesiredPositionMult { get; set;}

		public CR4PlayerStateExtendedMovable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4PlayerStateExtendedMovable(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}