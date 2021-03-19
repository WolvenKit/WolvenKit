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
			get => GetProperty(ref _movePolicies);
			set => SetProperty(ref _movePolicies, value);
		}

		public moveMovePoliciesComponentReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
