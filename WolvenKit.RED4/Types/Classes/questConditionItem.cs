using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questConditionItem : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get => GetPropertyValue<CHandle<questIBaseCondition>>();
			set => SetPropertyValue<CHandle<questIBaseCondition>>(value);
		}

		[Ordinal(1)] 
		[RED("socketId")] 
		public CUInt32 SocketId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public questConditionItem()
		{
			SocketId = 142650156;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
