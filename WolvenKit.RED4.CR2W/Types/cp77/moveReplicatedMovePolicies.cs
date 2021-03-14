using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveReplicatedMovePolicies : entReplicatedItem
	{
		private CUInt64 _key;
		private CHandle<movePolicies> _policies;

		[Ordinal(2)] 
		[RED("key")] 
		public CUInt64 Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CUInt64) CR2WTypeManager.Create("Uint64", "key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("policies")] 
		public CHandle<movePolicies> Policies
		{
			get
			{
				if (_policies == null)
				{
					_policies = (CHandle<movePolicies>) CR2WTypeManager.Create("handle:movePolicies", "policies", cr2w, this);
				}
				return _policies;
			}
			set
			{
				if (_policies == value)
				{
					return;
				}
				_policies = value;
				PropertySet(this);
			}
		}

		public moveReplicatedMovePolicies(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
