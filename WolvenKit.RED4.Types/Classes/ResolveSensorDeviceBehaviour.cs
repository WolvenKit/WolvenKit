using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ResolveSensorDeviceBehaviour : redEvent
	{
		[Ordinal(0)] 
		[RED("iteration")] 
		public CInt32 Iteration
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
