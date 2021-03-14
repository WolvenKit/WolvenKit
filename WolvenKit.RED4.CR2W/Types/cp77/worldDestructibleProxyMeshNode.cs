using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		private CUInt64 _ownerHash;

		[Ordinal(19)] 
		[RED("ownerHash")] 
		public CUInt64 OwnerHash
		{
			get
			{
				if (_ownerHash == null)
				{
					_ownerHash = (CUInt64) CR2WTypeManager.Create("Uint64", "ownerHash", cr2w, this);
				}
				return _ownerHash;
			}
			set
			{
				if (_ownerHash == value)
				{
					return;
				}
				_ownerHash = value;
				PropertySet(this);
			}
		}

		public worldDestructibleProxyMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
