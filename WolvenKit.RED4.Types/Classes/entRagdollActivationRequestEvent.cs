using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entRagdollActivationRequestEvent : redEvent
	{
		private entragdollActivationRequestData _data;

		[Ordinal(0)] 
		[RED("data")] 
		public entragdollActivationRequestData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
