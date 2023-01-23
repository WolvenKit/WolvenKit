using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DestructionData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("durabilityType")] 
		public CEnum<EDeviceDurabilityType> DurabilityType
		{
			get => GetPropertyValue<CEnum<EDeviceDurabilityType>>();
			set => SetPropertyValue<CEnum<EDeviceDurabilityType>>(value);
		}

		[Ordinal(1)] 
		[RED("canBeFixed")] 
		public CBool CanBeFixed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DestructionData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
