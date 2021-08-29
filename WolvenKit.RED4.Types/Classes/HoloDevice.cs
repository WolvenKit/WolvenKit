using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HoloDevice : InteractiveDevice
	{
		private CName _questFactName;

		[Ordinal(97)] 
		[RED("questFactName")] 
		public CName QuestFactName
		{
			get => GetProperty(ref _questFactName);
			set => SetProperty(ref _questFactName, value);
		}
	}
}
