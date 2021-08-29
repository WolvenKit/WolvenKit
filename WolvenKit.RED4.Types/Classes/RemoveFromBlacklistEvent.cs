using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveFromBlacklistEvent : redEvent
	{
		private entEntityID _entityIDToRemove;

		[Ordinal(0)] 
		[RED("entityIDToRemove")] 
		public entEntityID EntityIDToRemove
		{
			get => GetProperty(ref _entityIDToRemove);
			set => SetProperty(ref _entityIDToRemove, value);
		}
	}
}
