using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entUncontrolledMovementStartEvent : redEvent
	{
		private CFloat _ragdollNoGroundThreshold;
		private CBool _ragdollOnCollision;

		[Ordinal(0)] 
		[RED("ragdollNoGroundThreshold")] 
		public CFloat RagdollNoGroundThreshold
		{
			get
			{
				if (_ragdollNoGroundThreshold == null)
				{
					_ragdollNoGroundThreshold = (CFloat) CR2WTypeManager.Create("Float", "ragdollNoGroundThreshold", cr2w, this);
				}
				return _ragdollNoGroundThreshold;
			}
			set
			{
				if (_ragdollNoGroundThreshold == value)
				{
					return;
				}
				_ragdollNoGroundThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ragdollOnCollision")] 
		public CBool RagdollOnCollision
		{
			get
			{
				if (_ragdollOnCollision == null)
				{
					_ragdollOnCollision = (CBool) CR2WTypeManager.Create("Bool", "ragdollOnCollision", cr2w, this);
				}
				return _ragdollOnCollision;
			}
			set
			{
				if (_ragdollOnCollision == value)
				{
					return;
				}
				_ragdollOnCollision = value;
				PropertySet(this);
			}
		}

		public entUncontrolledMovementStartEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
