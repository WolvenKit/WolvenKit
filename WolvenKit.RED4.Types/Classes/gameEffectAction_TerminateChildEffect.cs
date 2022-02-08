using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectAction_TerminateChildEffect : gameEffectAction
	{
		[Ordinal(0)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}
	}
}
