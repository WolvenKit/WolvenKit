using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ConstantStatPoolPrereqListener : BaseStatPoolPrereqListener
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CWeakHandle<ConstantStatPoolPrereqState> State
		{
			get => GetPropertyValue<CWeakHandle<ConstantStatPoolPrereqState>>();
			set => SetPropertyValue<CWeakHandle<ConstantStatPoolPrereqState>>(value);
		}
	}
}
