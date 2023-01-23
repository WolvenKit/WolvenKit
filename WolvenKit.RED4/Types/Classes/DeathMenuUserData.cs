using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DeathMenuUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("playInitAnimation")] 
		public CBool PlayInitAnimation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DeathMenuUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
