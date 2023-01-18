using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpiderbotScavengeOptions : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("scavengableBySpiderbot")] 
		public CBool ScavengableBySpiderbot
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SpiderbotScavengeOptions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
