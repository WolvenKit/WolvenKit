using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animBoolLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_BoolValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_BoolValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_BoolValue>>(value);
		}
	}
}
