using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HasNewMountRequest : AIVehicleConditionAbstract
	{
		[Ordinal(0)] 
		[RED("mountRequest")] 
		public CHandle<AIArgumentMapping> MountRequest
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}

		[Ordinal(1)] 
		[RED("checkOnlyInstant")] 
		public CBool CheckOnlyInstant
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
