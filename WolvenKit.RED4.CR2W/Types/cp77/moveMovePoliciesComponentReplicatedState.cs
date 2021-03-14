using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveMovePoliciesComponentReplicatedState : netIComponentState
	{
		private moveReplicatedMovePoliciesState _movePolicies;

		[Ordinal(2)] 
		[RED("movePolicies")] 
		public moveReplicatedMovePoliciesState MovePolicies
		{
			get
			{
				if (_movePolicies == null)
				{
					_movePolicies = (moveReplicatedMovePoliciesState) CR2WTypeManager.Create("moveReplicatedMovePoliciesState", "movePolicies", cr2w, this);
				}
				return _movePolicies;
			}
			set
			{
				if (_movePolicies == value)
				{
					return;
				}
				_movePolicies = value;
				PropertySet(this);
			}
		}

		public moveMovePoliciesComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
