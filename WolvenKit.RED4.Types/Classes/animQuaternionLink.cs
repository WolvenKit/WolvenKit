using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animQuaternionLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_QuaternionValue> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_QuaternionValue>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_QuaternionValue>>(value);
		}
	}
}
