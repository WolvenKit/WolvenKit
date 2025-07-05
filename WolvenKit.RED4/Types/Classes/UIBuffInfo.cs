using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIBuffInfo : gameuiBuffInfo
	{
		[Ordinal(4)] 
		[RED("isBuff")] 
		public CBool IsBuff
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIBuffInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
