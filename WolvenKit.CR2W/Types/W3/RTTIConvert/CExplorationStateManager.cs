using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CExplorationStateManager : CSelfUpdatingComponent
	{
		[RED("m_InputO")] 		public CHandle<CExplorationInput> M_InputO { get; set;}

		[RED("m_MoverO")] 		public CHandle<CExplorationMover> M_MoverO { get; set;}

		[RED("m_SharedDataO")] 		public CHandle<CExplorationSharedData> M_SharedDataO { get; set;}

		[RED("m_CollisionManagerO")] 		public CHandle<CExplorationCollisionManager> M_CollisionManagerO { get; set;}

		[RED("m_MovementCorrectorO")] 		public CHandle<CExplorationMovementCorrector> M_MovementCorrectorO { get; set;}

		[RED("m_DefaultCameraSetS")] 		public CHandle<CCameraParametersSet> M_DefaultCameraSetS { get; set;}

		[RED("m_TeleportedFallHackTimeTotalF")] 		public CFloat M_TeleportedFallHackTimeTotalF { get; set;}

		public CExplorationStateManager(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CExplorationStateManager(cr2w);

	}
}