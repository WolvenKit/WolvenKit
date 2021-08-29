using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetPersistentForcedHighlightEvent : redEvent
	{
		private CName _sourceName;
		private CHandle<HighlightEditableData> _highlightData;
		private CEnum<EToggleOperationType> _operation;

		[Ordinal(0)] 
		[RED("sourceName")] 
		public CName SourceName
		{
			get => GetProperty(ref _sourceName);
			set => SetProperty(ref _sourceName, value);
		}

		[Ordinal(1)] 
		[RED("highlightData")] 
		public CHandle<HighlightEditableData> HighlightData
		{
			get => GetProperty(ref _highlightData);
			set => SetProperty(ref _highlightData, value);
		}

		[Ordinal(2)] 
		[RED("operation")] 
		public CEnum<EToggleOperationType> Operation
		{
			get => GetProperty(ref _operation);
			set => SetProperty(ref _operation, value);
		}
	}
}
