using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DamageTypeIndicator : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("DamageIconRef")] 
		public inkImageWidgetReference DamageIconRef
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("DamageTypeLabelRef")] 
		public inkTextWidgetReference DamageTypeLabelRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public DamageTypeIndicator()
		{
			DamageIconRef = new();
			DamageTypeLabelRef = new();
		}
	}
}
