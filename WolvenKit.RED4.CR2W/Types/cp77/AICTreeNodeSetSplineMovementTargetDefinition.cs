using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeSetSplineMovementTargetDefinition : AICTreeNodeDecoratorDefinition
	{
		private LibTreeSharedVarReferenceName _splineNode;
		private LibTreeSharedVarRegistrationName _movementTarget;

		[Ordinal(1)] 
		[RED("splineNode")] 
		public LibTreeSharedVarReferenceName SplineNode
		{
			get
			{
				if (_splineNode == null)
				{
					_splineNode = (LibTreeSharedVarReferenceName) CR2WTypeManager.Create("LibTreeSharedVarReferenceName", "splineNode", cr2w, this);
				}
				return _splineNode;
			}
			set
			{
				if (_splineNode == value)
				{
					return;
				}
				_splineNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("movementTarget")] 
		public LibTreeSharedVarRegistrationName MovementTarget
		{
			get
			{
				if (_movementTarget == null)
				{
					_movementTarget = (LibTreeSharedVarRegistrationName) CR2WTypeManager.Create("LibTreeSharedVarRegistrationName", "movementTarget", cr2w, this);
				}
				return _movementTarget;
			}
			set
			{
				if (_movementTarget == value)
				{
					return;
				}
				_movementTarget = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeSetSplineMovementTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
