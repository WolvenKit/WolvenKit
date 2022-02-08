using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AddOrRemoveListenerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<PuppetListener> Listener
		{
			get => GetPropertyValue<CHandle<PuppetListener>>();
			set => SetPropertyValue<CHandle<PuppetListener>>(value);
		}

		[Ordinal(1)] 
		[RED("add")] 
		public CBool Add
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
