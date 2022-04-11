using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entAnimInputSetterBool : entAnimInputSetter
	{
		[Ordinal(1)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
