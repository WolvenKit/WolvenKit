using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldDestructibleProxyMeshNode : worldPrefabProxyMeshNode
	{
		private CUInt64 _ownerHash;

		[Ordinal(19)] 
		[RED("ownerHash")] 
		public CUInt64 OwnerHash
		{
			get => GetProperty(ref _ownerHash);
			set => SetProperty(ref _ownerHash, value);
		}
	}
}
