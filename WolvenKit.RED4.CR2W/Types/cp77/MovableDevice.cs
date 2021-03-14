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

		[Ordinal(93)] 
		[RED("workspotSideName")] 
		public CName WorkspotSideName
		{
			get
			{
				if (_workspotSideName == null)
				{
					_workspotSideName = (CName) CR2WTypeManager.Create("CName", "workspotSideName", cr2w, this);
				}
				return _workspotSideName;
			}
			set
			{
				if (_workspotSideName == value)
				{
					return;
				}
				_workspotSideName = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("sideTriggerNames")] 
		public CArray<CName> SideTriggerNames
		{
			get
			{
				if (_sideTriggerNames == null)
				{
					_sideTriggerNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "sideTriggerNames", cr2w, this);
				}
				return _sideTriggerNames;
			}
			set
			{
				if (_sideTriggerNames == value)
				{
					return;
				}
				_sideTriggerNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("triggerComponents")] 
		public CArray<CHandle<gameStaticTriggerAreaComponent>> TriggerComponents
		{
			get
			{
				if (_triggerComponents == null)
				{
					_triggerComponents = (CArray<CHandle<gameStaticTriggerAreaComponent>>) CR2WTypeManager.Create("array:handle:gameStaticTriggerAreaComponent", "triggerComponents", cr2w, this);
				}
				return _triggerComponents;
			}
			set
			{
				if (_triggerComponents == value)
				{
					return;
				}
				_triggerComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("offMeshConnectionsToOpenNames")] 
		public CArray<CName> OffMeshConnectionsToOpenNames
		{
			get
			{
				if (_offMeshConnectionsToOpenNames == null)
				{
					_offMeshConnectionsToOpenNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "offMeshConnectionsToOpenNames", cr2w, this);
				}
				return _offMeshConnectionsToOpenNames;
			}
			set
			{
				if (_offMeshConnectionsToOpenNames == value)
				{
					return;
				}
				_offMeshConnectionsToOpenNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("offMeshConnectionsToOpen")] 
		public CArray<CHandle<AIOffMeshConnectionComponent>> OffMeshConnectionsToOpen
		{
			get
			{
				if (_offMeshConnectionsToOpen == null)
				{
					_offMeshConnectionsToOpen = (CArray<CHandle<AIOffMeshConnectionComponent>>) CR2WTypeManager.Create("array:handle:AIOffMeshConnectionComponent", "offMeshConnectionsToOpen", cr2w, this);
				}
				return _offMeshConnectionsToOpen;
			}
			set
			{
				if (_offMeshConnectionsToOpen == value)
				{
					return;
				}
				_offMeshConnectionsToOpen = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("additionalMeshComponent")] 
		public CHandle<entMeshComponent> AdditionalMeshComponent
		{
			get
			{
				if (_additionalMeshComponent == null)
				{
					_additionalMeshComponent = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "additionalMeshComponent", cr2w, this);
				}
				return _additionalMeshComponent;
			}
			set
			{
				if (_additionalMeshComponent == value)
				{
					return;
				}
				_additionalMeshComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("UseWorkspotComponentPosition")] 
		public CBool UseWorkspotComponentPosition
		{
			get
			{
				if (_useWorkspotComponentPosition == null)
				{
					_useWorkspotComponentPosition = (CBool) CR2WTypeManager.Create("Bool", "UseWorkspotComponentPosition", cr2w, this);
				}
				return _useWorkspotComponentPosition;
			}
			set
			{
				if (_useWorkspotComponentPosition == value)
				{
					return;
				}
				_useWorkspotComponentPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("shouldMoveRight")] 
		public CBool ShouldMoveRight
		{
			get
			{
				if (_shouldMoveRight == null)
				{
					_shouldMoveRight = (CBool) CR2WTypeManager.Create("Bool", "shouldMoveRight", cr2w, this);
				}
				return _shouldMoveRight;
			}
			set
			{
				if (_shouldMoveRight == value)
				{
					return;
				}
				_shouldMoveRight = value;
				PropertySet(this);
			}
		}

		public MovableDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
