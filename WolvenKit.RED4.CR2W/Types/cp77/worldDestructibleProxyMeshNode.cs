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
			get => GetProperty(ref _ownerHash);
			set => SetProperty(ref _ownerHash, value);
		}

		public worldDestructibleProxyMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
