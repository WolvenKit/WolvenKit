using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpiderbotScavengeOptions : RedBaseClass
	{
		private CBool _scavengableBySpiderbot;

		[Ordinal(0)] 
		[RED("scavengableBySpiderbot")] 
		public CBool ScavengableBySpiderbot
		{
			get => GetProperty(ref _scavengableBySpiderbot);
			set => SetProperty(ref _scavengableBySpiderbot, value);
		}
	}
}
