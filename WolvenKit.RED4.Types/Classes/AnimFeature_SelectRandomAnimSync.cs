using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_SelectRandomAnimSync : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
