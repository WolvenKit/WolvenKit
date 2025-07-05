using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemWeaponBar : IScriptable
	{
		[Ordinal(0)] 
		[RED("Value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("MaxValue")] 
		public CFloat MaxValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("Percentage")] 
		public CFloat Percentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("Type")] 
		public CEnum<WeaponBarType> Type
		{
			get => GetPropertyValue<CEnum<WeaponBarType>>();
			set => SetPropertyValue<CEnum<WeaponBarType>>(value);
		}

		[Ordinal(4)] 
		[RED("isValueSet")] 
		public CBool IsValueSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public UIInventoryItemWeaponBar()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
