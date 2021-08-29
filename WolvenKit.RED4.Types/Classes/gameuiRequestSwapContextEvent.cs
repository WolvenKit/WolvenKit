using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRequestSwapContextEvent : redEvent
	{
		private CEnum<UIGameContext> _oldContext;
		private CEnum<UIGameContext> _newContext;

		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<UIGameContext> OldContext
		{
			get => GetProperty(ref _oldContext);
			set => SetProperty(ref _oldContext, value);
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<UIGameContext> NewContext
		{
			get => GetProperty(ref _newContext);
			set => SetProperty(ref _newContext, value);
		}
	}
}
