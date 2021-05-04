using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MovableDevice : InteractiveDevice
	{
		private CName _workspotSideName;
		private CArray<CName> _sideTriggerNames;
		private CArray<CHandle<gameStaticTriggerAreaComponent>> _triggerComponents;
		private CArray<CName> _offMeshConnectionsToOpenNames;
		private CArray<CHandle<AIOffMeshConnectionComponent>> _offMeshConnectionsToOpen;
		private CHandle<entMeshComponent> _additionalMeshComponent;
		private CBool _useWorkspotComponentPosition;
		private CBool _shouldMoveRight;

		[Ordinal(96)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get => GetProperty(ref _workspotSideName);
			set => SetProperty(ref _workspotSideName, value);
		}

		[Ordinal(97)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get => GetProperty(ref _sideTriggerNames);
			set => SetProperty(ref _sideTriggerNames, value);
		}

		[Ordinal(98)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get => GetProperty(ref _triggerComponents);
			set => SetProperty(ref _triggerComponents, value);
		}

		[Ordinal(99)] 
		[RED("offMeshConnectionsToOpenNames")] 
		public CArray<CName> OffMeshConnectionsToOpenNames
		{
			get => GetProperty(ref _offMeshConnectionsToOpenNames);
			set => SetProperty(ref _offMeshConnectionsToOpenNames, value);
		}

		[Ordinal(100)] 
		[RED("offMeshConnectionsToOpen")] 
		public CArray<CHandle<AIOffMeshConnectionComponent>> OffMeshConnectionsToOpen
		{
			get => GetProperty(ref _offMeshConnectionsToOpen);
			set => SetProperty(ref _offMeshConnectionsToOpen, value);
		}

		[Ordinal(101)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get => GetProperty(ref _additionalMeshComponent);
			set => SetProperty(ref _additionalMeshComponent, value);
		}

		[Ordinal(102)] 
		[RED("UseWorkspotComponentPosition")] 
		public CBool UseWorkspotComponentPosition
		{
			get => GetProperty(ref _useWorkspotComponentPosition);
			set => SetProperty(ref _useWorkspotComponentPosition, value);
		}

		[Ordinal(103)] 
		[RED("shouldMoveRight")] 
		public CBool ShouldMoveRight
		{
			get => GetProperty(ref _shouldMoveRight);
			set => SetProperty(ref _shouldMoveRight, value);
		}

		public MovableDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
