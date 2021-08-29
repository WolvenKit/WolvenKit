using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedEntityEvent : entReplicatedItem
	{
		private CHandle<redEvent> _value;

		[Ordinal(2)] 
		[RED("value")] 
		public CHandle<redEvent> Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}
	}
}
