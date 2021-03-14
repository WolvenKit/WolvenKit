using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorActionTeleportTreeNodeDefinition : AIbehaviorActionTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _destinationPoint;
		private CHandle<AIArgumentMapping> _doNavTest;
		private CHandle<AIArgumentMapping> _rotation;

		[Ordinal(1)] 
		[RED("destinationPoint")] 
		public CHandle<AIArgumentMapping> DestinationPoint
		{
			get
			{
				if (_destinationPoint == null)
				{
					_destinationPoint = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "destinationPoint", cr2w, this);
				}
				return _destinationPoint;
			}
			set
			{
				if (_destinationPoint == value)
				{
					return;
				}
				_destinationPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("doNavTest")] 
		public CHandle<AIArgumentMapping> DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rotation")] 
		public CHandle<AIArgumentMapping> Rotation
		{
			get
			{
				if (_rotation == null)
				{
					_rotation = (CHandle<AIArgumentMapping>) CR2WTypeManager.Create("handle:AIArgumentMapping", "rotation", cr2w, this);
				}
				return _rotation;
			}
			set
			{
				if (_rotation == value)
				{
					return;
				}
				_rotation = value;
				PropertySet(this);
			}
		}

		public AIbehaviorActionTeleportTreeNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
