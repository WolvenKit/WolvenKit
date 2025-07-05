using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorBehaviorInstanceCallStack : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resourceHashes")] 
		public CArray<CUInt32> ResourceHashes
		{
			get => GetPropertyValue<CArray<CUInt32>>();
			set => SetPropertyValue<CArray<CUInt32>>(value);
		}

		public AIbehaviorBehaviorInstanceCallStack()
		{
			ResourceHashes = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
