using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CacheStatusEffectAnimEvent : redEvent
	{
		private CBool _removeCachedStatusEffect;

		[Ordinal(0)] 
		[RED("removeCachedStatusEffect")] 
		public CBool RemoveCachedStatusEffect
		{
			get => GetProperty(ref _removeCachedStatusEffect);
			set => SetProperty(ref _removeCachedStatusEffect, value);
		}
	}
}
