using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectWorkspotEntryTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _workspotData;
		private CHandle<AIArgumentMapping> _destinationPosition;
		private CHandle<AIArgumentMapping> _tangentPoint;
		private CHandle<AIArgumentMapping> _entranceFromStand;

		[Ordinal(1)] 
		[RED("workspotData")] 
		public CHandle<AIArgumentMapping> WorkspotData
		{
			get
			{
				if (_workspotData == null)
				{
					_workspotData = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "workspotData", cr2w, this);
				}
				return _workspotData;
			}
			set
			{
				if (_workspotData == value)
				{
					return;
				}
				_workspotData = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get
			{
				if (_destinationPosition == null)
				{
					_destinationPosition = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "destinationPosition", cr2w, this);
				}
				return _destinationPosition;
			}
			set
			{
				if (_destinationPosition == value)
				{
					return;
				}
				_destinationPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("tangentPoint")] 
		public CHandle<AIArgumentMapping> TangentPoint
		{
			get
			{
				if (_tangentPoint == null)
				{
					_tangentPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "tangentPoint", cr2w, this);
				}
				return _tangentPoint;
			}
			set
			{
				if (_tangentPoint == value)
				{
					return;
				}
				_tangentPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("entranceFromStand")] 
		public CHandle<AIArgumentMapping> EntranceFromStand
		{
			get
			{
				if (_entranceFromStand == null)
				{
					_entranceFromStand = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "entranceFromStand", cr2w, this);
				}
				return _entranceFromStand;
			}
			set
			{
				if (_entranceFromStand == value)
				{
					return;
				}
				_entranceFromStand = value;
				PropertySet(this);
			}
		}

		public AIbehaviorSelectWorkspotEntryTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
