using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIRagdollDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private wCHandle<gameObject> _ragdollInstigator;
		private Vector4 _closestNavmeshPoint;
		private CBool _ragdollOutOfNavmesh;
		private CBool _isUnderwater;
		private CBool _poseAllowsRecovery;

		[Ordinal(0)] 
		[RED("ragdollInstigator")] 
		public wCHandle<gameObject> RagdollInstigator
		{
			get
			{
				if (_ragdollInstigator == null)
				{
					_ragdollInstigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "ragdollInstigator", cr2w, this);
				}
				return _ragdollInstigator;
			}
			set
			{
				if (_ragdollInstigator == value)
				{
					return;
				}
				_ragdollInstigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("closestNavmeshPoint")] 
		public Vector4 ClosestNavmeshPoint
		{
			get
			{
				if (_closestNavmeshPoint == null)
				{
					_closestNavmeshPoint = (Vector4) CR2WTypeManager.Create("Vector4", "closestNavmeshPoint", cr2w, this);
				}
				return _closestNavmeshPoint;
			}
			set
			{
				if (_closestNavmeshPoint == value)
				{
					return;
				}
				_closestNavmeshPoint = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("ragdollOutOfNavmesh")] 
		public CBool RagdollOutOfNavmesh
		{
			get
			{
				if (_ragdollOutOfNavmesh == null)
				{
					_ragdollOutOfNavmesh = (CBool) CR2WTypeManager.Create("Bool", "ragdollOutOfNavmesh", cr2w, this);
				}
				return _ragdollOutOfNavmesh;
			}
			set
			{
				if (_ragdollOutOfNavmesh == value)
				{
					return;
				}
				_ragdollOutOfNavmesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("isUnderwater")] 
		public CBool IsUnderwater
		{
			get
			{
				if (_isUnderwater == null)
				{
					_isUnderwater = (CBool) CR2WTypeManager.Create("Bool", "isUnderwater", cr2w, this);
				}
				return _isUnderwater;
			}
			set
			{
				if (_isUnderwater == value)
				{
					return;
				}
				_isUnderwater = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("poseAllowsRecovery")] 
		public CBool PoseAllowsRecovery
		{
			get
			{
				if (_poseAllowsRecovery == null)
				{
					_poseAllowsRecovery = (CBool) CR2WTypeManager.Create("Bool", "poseAllowsRecovery", cr2w, this);
				}
				return _poseAllowsRecovery;
			}
			set
			{
				if (_poseAllowsRecovery == value)
				{
					return;
				}
				_poseAllowsRecovery = value;
				PropertySet(this);
			}
		}

		public AIRagdollDelegate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
