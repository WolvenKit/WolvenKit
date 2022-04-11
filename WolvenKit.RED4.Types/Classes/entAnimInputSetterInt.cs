using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterInt : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}
	}
}
