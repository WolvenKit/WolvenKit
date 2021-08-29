using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InventoryItemAttachmentDisplay : inkWidgetLogicController
	{
		private inkWidgetReference _qualityRootRef;
		private inkWidgetReference _shapeRef;
		private inkWidgetReference _borderRef;
		private CName _markedStateName;

		[Ordinal(1)] 
		[RED("QualityRootRef")] 
		public inkWidgetReference QualityRootRef
		{
			get => GetProperty(ref _qualityRootRef);
			set => SetProperty(ref _qualityRootRef, value);
		}

		[Ordinal(2)] 
		[RED("ShapeRef")] 
		public inkWidgetReference ShapeRef
		{
			get => GetProperty(ref _shapeRef);
			set => SetProperty(ref _shapeRef, value);
		}

		[Ordinal(3)] 
		[RED("BorderRef")] 
		public inkWidgetReference BorderRef
		{
			get => GetProperty(ref _borderRef);
			set => SetProperty(ref _borderRef, value);
		}

		[Ordinal(4)] 
		[RED("MarkedStateName")] 
		public CName MarkedStateName
		{
			get => GetProperty(ref _markedStateName);
			set => SetProperty(ref _markedStateName, value);
		}
	}
}
