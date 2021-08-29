using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioMeleeEvent : RedBaseClass
	{
		private CName _event;
		private CArray<audioAudSimpleParameter> _params;

		[Ordinal(0)] 
		[RED("event")] 
		public CName Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CArray<audioAudSimpleParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}
	}
}
