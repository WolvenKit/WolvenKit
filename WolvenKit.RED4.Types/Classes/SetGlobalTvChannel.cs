using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetGlobalTvChannel : redEvent
	{
		[Ordinal(0)] 
		[RED("channel")] 
		public TweakDBID Channel
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
	}
}
