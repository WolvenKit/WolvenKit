using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldRelativeNodePathElement : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prefab")] 
		public CString Prefab
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("nodeID")] 
		public CUInt64 NodeID
		{
			get => GetPropertyValue<CUInt64>();
			set => SetPropertyValue<CUInt64>(value);
		}

		public worldRelativeNodePathElement()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
