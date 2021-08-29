using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CyberwareAttributes_ContainersStruct : RedBaseClass
	{
		private inkWidgetReference _widgetBody;
		private inkWidgetReference _widgetCool;
		private inkWidgetReference _widgetInt;
		private inkWidgetReference _widgetRef;
		private inkWidgetReference _widgetTech;
		private CWeakHandle<CyberwareAttributes_Logic> _logicBody;
		private CWeakHandle<CyberwareAttributes_Logic> _logicCool;
		private CWeakHandle<CyberwareAttributes_Logic> _logicInt;
		private CWeakHandle<CyberwareAttributes_Logic> _logicRef;
		private CWeakHandle<CyberwareAttributes_Logic> _logicTech;

		[Ordinal(0)] 
		[RED("widgetBody")] 
		public inkWidgetReference WidgetBody
		{
			get => GetProperty(ref _widgetBody);
			set => SetProperty(ref _widgetBody, value);
		}

		[Ordinal(1)] 
		[RED("widgetCool")] 
		public inkWidgetReference WidgetCool
		{
			get => GetProperty(ref _widgetCool);
			set => SetProperty(ref _widgetCool, value);
		}

		[Ordinal(2)] 
		[RED("widgetInt")] 
		public inkWidgetReference WidgetInt
		{
			get => GetProperty(ref _widgetInt);
			set => SetProperty(ref _widgetInt, value);
		}

		[Ordinal(3)] 
		[RED("widgetRef")] 
		public inkWidgetReference WidgetRef
		{
			get => GetProperty(ref _widgetRef);
			set => SetProperty(ref _widgetRef, value);
		}

		[Ordinal(4)] 
		[RED("widgetTech")] 
		public inkWidgetReference WidgetTech
		{
			get => GetProperty(ref _widgetTech);
			set => SetProperty(ref _widgetTech, value);
		}

		[Ordinal(5)] 
		[RED("logicBody")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicBody
		{
			get => GetProperty(ref _logicBody);
			set => SetProperty(ref _logicBody, value);
		}

		[Ordinal(6)] 
		[RED("logicCool")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicCool
		{
			get => GetProperty(ref _logicCool);
			set => SetProperty(ref _logicCool, value);
		}

		[Ordinal(7)] 
		[RED("logicInt")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicInt
		{
			get => GetProperty(ref _logicInt);
			set => SetProperty(ref _logicInt, value);
		}

		[Ordinal(8)] 
		[RED("logicRef")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicRef
		{
			get => GetProperty(ref _logicRef);
			set => SetProperty(ref _logicRef, value);
		}

		[Ordinal(9)] 
		[RED("logicTech")] 
		public CWeakHandle<CyberwareAttributes_Logic> LogicTech
		{
			get => GetProperty(ref _logicTech);
			set => SetProperty(ref _logicTech, value);
		}
	}
}
