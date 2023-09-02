using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberwareAttributes_ContainersStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("widgetBody")] 
		public inkWidgetReference WidgetBody
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(1)] 
		[RED("widgetCool")] 
		public inkWidgetReference WidgetCool
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("widgetInt")] 
		public inkWidgetReference WidgetInt
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("widgetRef")] 
		public inkWidgetReference WidgetRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("widgetTech")] 
		public inkWidgetReference WidgetTech
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("logicBody")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicBody
		{
			get => GetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>();
			set => SetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>(value);
		}

		[Ordinal(6)] 
		[RED("logicCool")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicCool
		{
			get => GetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>();
			set => SetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>(value);
		}

		[Ordinal(7)] 
		[RED("logicInt")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicInt
		{
			get => GetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>();
			set => SetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>(value);
		}

		[Ordinal(8)] 
		[RED("logicRef")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicRef
		{
			get => GetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>();
			set => SetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>(value);
		}

		[Ordinal(9)] 
		[RED("logicTech")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicTech
		{
			get => GetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>();
			set => SetPropertyValue<CWeakHandle<CyberwareAttributes_Logic>>(value);
		}

		public CyberwareAttributes_ContainersStruct()
		{
			WidgetBody = new inkWidgetReference();
			WidgetCool = new inkWidgetReference();
			WidgetInt = new inkWidgetReference();
			WidgetRef = new inkWidgetReference();
			WidgetTech = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
