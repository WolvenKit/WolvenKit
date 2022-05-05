using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_Container : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("nodes")] 
		public CArray<CHandle<animAnimNode_Base>> Nodes
		{
			get => GetPropertyValue<CArray<CHandle<animAnimNode_Base>>>();
			set => SetPropertyValue<CArray<CHandle<animAnimNode_Base>>>(value);
		}

		public animAnimNode_Container()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
