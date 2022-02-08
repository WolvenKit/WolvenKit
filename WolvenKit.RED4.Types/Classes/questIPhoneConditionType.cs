using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questIPhoneConditionType : questIUIConditionType
	{
		[Ordinal(0)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
