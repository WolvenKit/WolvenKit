using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveFromBlacklistEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RemoveFromBlacklistEvent()
		{
			EntityIDToRemove = new();
		}
	}
}
