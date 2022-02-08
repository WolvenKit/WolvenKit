using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_QuickMelee : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CInt32 State
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
