using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountRequestConditionDefinition : AIbehaviorConditionDefinition
	{
		private CBool _testMountRequest;
		private CBool _testUnmountRequest;
		private CBool _acceptInstant;
		private CBool _acceptNotInstant;

		[Ordinal(1)] 
		[RED("testMountRequest")] 
		public CBool TestMountRequest
		{
			get
			{
				if (_testMountRequest == null)
				{
					_testMountRequest = (CBool) CR2WTypeManager.Create("Bool", "testMountRequest", cr2w, this);
				}
				return _testMountRequest;
			}
			set
			{
				if (_testMountRequest == value)
				{
					return;
				}
				_testMountRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("testUnmountRequest")] 
		public CBool TestUnmountRequest
		{
			get
			{
				if (_testUnmountRequest == null)
				{
					_testUnmountRequest = (CBool) CR2WTypeManager.Create("Bool", "testUnmountRequest", cr2w, this);
				}
				return _testUnmountRequest;
			}
			set
			{
				if (_testUnmountRequest == value)
				{
					return;
				}
				_testUnmountRequest = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("acceptInstant")] 
		public CBool AcceptInstant
		{
			get
			{
				if (_acceptInstant == null)
				{
					_acceptInstant = (CBool) CR2WTypeManager.Create("Bool", "acceptInstant", cr2w, this);
				}
				return _acceptInstant;
			}
			set
			{
				if (_acceptInstant == value)
				{
					return;
				}
				_acceptInstant = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("acceptNotInstant")] 
		public CBool AcceptNotInstant
		{
			get
			{
				if (_acceptNotInstant == null)
				{
					_acceptNotInstant = (CBool) CR2WTypeManager.Create("Bool", "acceptNotInstant", cr2w, this);
				}
				return _acceptNotInstant;
			}
			set
			{
				if (_acceptNotInstant == value)
				{
					return;
				}
				_acceptNotInstant = value;
				PropertySet(this);
			}
		}

		public AIbehaviorMountRequestConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
