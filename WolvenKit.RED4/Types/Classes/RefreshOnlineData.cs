using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RefreshOnlineData : IScriptable
	{
		[Ordinal(0)] 
		[RED("isOnline")] 
		public CBool IsOnline
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public RefreshOnlineData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
