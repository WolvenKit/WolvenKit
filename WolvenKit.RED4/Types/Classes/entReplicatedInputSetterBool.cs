using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entReplicatedInputSetterBool : entReplicatedInputSetterBase
	{
		[Ordinal(2)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public entReplicatedInputSetterBool()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
