using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TimetableCallbackData : IScriptable
	{
		[Ordinal(0)] 
		[RED("time")] 
		public SSimpleGameTime Time
		{
			get => GetPropertyValue<SSimpleGameTime>();
			set => SetPropertyValue<SSimpleGameTime>(value);
		}

		[Ordinal(1)] 
		[RED("recipients")] 
		public CArray<RecipientData> Recipients
		{
			get => GetPropertyValue<CArray<RecipientData>>();
			set => SetPropertyValue<CArray<RecipientData>>(value);
		}

		[Ordinal(2)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public TimetableCallbackData()
		{
			Time = new();
			Recipients = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
