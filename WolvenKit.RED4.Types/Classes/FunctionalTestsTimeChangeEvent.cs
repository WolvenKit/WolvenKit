using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsTimeChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("listenerId")] 
		public CUInt32 ListenerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}
	}
}
