using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResponseEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("responseData")] 
		public CHandle<IScriptable> ResponseData
		{
			get => GetPropertyValue<CHandle<IScriptable>>();
			set => SetPropertyValue<CHandle<IScriptable>>(value);
		}

		public ResponseEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
