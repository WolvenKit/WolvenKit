using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseLink : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_Base> Node
		{
			get => GetPropertyValue<CWeakHandle<animAnimNode_Base>>();
			set => SetPropertyValue<CWeakHandle<animAnimNode_Base>>(value);
		}
	}
}
