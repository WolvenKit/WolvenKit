using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questTeleportPuppetParamsV1 : questAICommandParams
	{
		private CHandle<questUniversalRef> _destinationRef;
		private Vector3 _destinationOffset;
		private CBool _doNavTest;
		private CBool _resetLookAt;
		private CBool _useFastTravelMechanism;
		private CBool _healAtTeleport;

		[Ordinal(0)] 
		[RED("destinationRef")] 
		public CHandle<questUniversalRef> DestinationRef
		{
			get => GetProperty(ref _destinationRef);
			set => SetProperty(ref _destinationRef, value);
		}

		[Ordinal(1)] 
		[RED("destinationOffset")] 
		public Vector3 DestinationOffset
		{
			get => GetProperty(ref _destinationOffset);
			set => SetProperty(ref _destinationOffset, value);
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get => GetProperty(ref _doNavTest);
			set => SetProperty(ref _doNavTest, value);
		}

		[Ordinal(3)] 
		[RED("resetLookAt")] 
		public CBool ResetLookAt
		{
			get => GetProperty(ref _resetLookAt);
			set => SetProperty(ref _resetLookAt, value);
		}

		[Ordinal(4)] 
		[RED("useFastTravelMechanism")] 
		public CBool UseFastTravelMechanism
		{
			get => GetProperty(ref _useFastTravelMechanism);
			set => SetProperty(ref _useFastTravelMechanism, value);
		}

		[Ordinal(5)] 
		[RED("healAtTeleport")] 
		public CBool HealAtTeleport
		{
			get => GetProperty(ref _healAtTeleport);
			set => SetProperty(ref _healAtTeleport, value);
		}

		public questTeleportPuppetParamsV1(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
