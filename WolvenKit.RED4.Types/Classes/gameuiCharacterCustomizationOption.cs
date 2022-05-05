using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCharacterCustomizationOption : IScriptable
	{
		[Ordinal(0)] 
		[RED("info")] 
		public CHandle<gameuiCharacterCustomizationInfo> Info
		{
			get => GetPropertyValue<CHandle<gameuiCharacterCustomizationInfo>>();
			set => SetPropertyValue<CHandle<gameuiCharacterCustomizationInfo>>(value);
		}

		[Ordinal(1)] 
		[RED("bodyPart")] 
		public CEnum<gameuiCharacterCustomizationPart> BodyPart
		{
			get => GetPropertyValue<CEnum<gameuiCharacterCustomizationPart>>();
			set => SetPropertyValue<CEnum<gameuiCharacterCustomizationPart>>(value);
		}

		[Ordinal(2)] 
		[RED("prevIndex")] 
		public CUInt32 PrevIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("currIndex")] 
		public CUInt32 CurrIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("isCensored")] 
		public CBool IsCensored
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isEditable")] 
		public CBool IsEditable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameuiCharacterCustomizationOption()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
