using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsDialogLine : redEvent
	{
		private audioDialogLineEventData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public audioDialogLineEventData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
