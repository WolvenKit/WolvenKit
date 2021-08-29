using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiContextChangedEvent : redEvent
	{
		private CEnum<gameuiContext> _oldContext;
		private CEnum<gameuiContext> _newContext;

		[Ordinal(0)] 
		[RED("oldContext")] 
		public CEnum<gameuiContext> OldContext
		{
			get => GetProperty(ref _oldContext);
			set => SetProperty(ref _oldContext, value);
		}

		[Ordinal(1)] 
		[RED("newContext")] 
		public CEnum<gameuiContext> NewContext
		{
			get => GetProperty(ref _newContext);
			set => SetProperty(ref _newContext, value);
		}
	}
}
