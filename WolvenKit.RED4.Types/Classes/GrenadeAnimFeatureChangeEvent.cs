using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GrenadeAnimFeatureChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CInt32 NewState
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
