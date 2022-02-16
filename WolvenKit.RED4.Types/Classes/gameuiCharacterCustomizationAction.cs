using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiCharacterCustomizationAction : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameuiCharacterCustomizationActionType> Type
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationActionType>>(value);
		}

		[Ordinal(1)] 
		[RED("params")] 
		public CString Params
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("applyImmediately")] 
		public CBool ApplyImmediately
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
