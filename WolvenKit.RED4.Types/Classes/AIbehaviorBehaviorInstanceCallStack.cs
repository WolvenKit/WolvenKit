using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorBehaviorInstanceCallStack : RedBaseClass
	{
		private CArray<CUInt32> _resourceHashes;

		[Ordinal(0)] 
		[RED("resourceHashes")] 
		public CArray<CUInt32> ResourceHashes
		{
			get => GetProperty(ref _resourceHashes);
			set => SetProperty(ref _resourceHashes, value);
		}
	}
}
