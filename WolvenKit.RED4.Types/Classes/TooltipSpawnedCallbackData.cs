using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TooltipSpawnedCallbackData : IScriptable
	{
		private CInt32 _index;
		private CName _identifier;
		private CEnum<ETooltipsStyle> _tooltipStyle;
		private redResourceReferenceScriptToken _styleResRef;

		[Ordinal(0)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("identifier")] 
		public CName Identifier
		{
			get => GetProperty(ref _identifier);
			set => SetProperty(ref _identifier, value);
		}

		[Ordinal(2)] 
		[RED("tooltipStyle")] 
		public CEnum<ETooltipsStyle> TooltipStyle
		{
			get => GetProperty(ref _tooltipStyle);
			set => SetProperty(ref _tooltipStyle, value);
		}

		[Ordinal(3)] 
		[RED("styleResRef")] 
		public redResourceReferenceScriptToken StyleResRef
		{
			get => GetProperty(ref _styleResRef);
			set => SetProperty(ref _styleResRef, value);
		}

		public TooltipSpawnedCallbackData()
		{
			_index = -1;
		}
	}
}
