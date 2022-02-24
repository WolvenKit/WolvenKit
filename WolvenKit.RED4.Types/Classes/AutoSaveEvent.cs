using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AutoSaveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("maxAttempts")] 
		public CInt32 MaxAttempts
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("isForced")] 
		public CBool IsForced
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AutoSaveEvent()
		{
			MaxAttempts = 1;
		}
	}
}
