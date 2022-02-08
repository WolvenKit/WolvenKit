using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animIntLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_IntValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_IntValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_IntValue>>(value);
		}
	}
}
