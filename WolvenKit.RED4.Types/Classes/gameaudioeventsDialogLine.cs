using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameaudioeventsDialogLine : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public audioDialogLineEventData Data
		{
			get => GetPropertyValue<audioDialogLineEventData>();
			set => SetPropertyValue<audioDialogLineEventData>(value);
		}

		public gameaudioeventsDialogLine()
		{
			Data = new();
		}
	}
}
