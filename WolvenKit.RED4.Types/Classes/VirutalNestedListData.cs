using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VirutalNestedListData : IScriptable
	{
		private CBool _collapsable;
		private CBool _isHeader;
		private CInt32 _level;
		private CBool _forceToTopWithinLevel;
		private CUInt32 _widgetType;
		private CHandle<IScriptable> _data;

		[Ordinal(0)] 
		[RED("collapsable")] 
		public CBool Collapsable
		{
			get => GetProperty(ref _collapsable);
			set => SetProperty(ref _collapsable, value);
		}

		[Ordinal(1)] 
		[RED("isHeader")] 
		public CBool IsHeader
		{
			get => GetProperty(ref _isHeader);
			set => SetProperty(ref _isHeader, value);
		}

		[Ordinal(2)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(3)] 
		[RED("forceToTopWithinLevel")] 
		public CBool ForceToTopWithinLevel
		{
			get => GetProperty(ref _forceToTopWithinLevel);
			set => SetProperty(ref _forceToTopWithinLevel, value);
		}

		[Ordinal(4)] 
		[RED("widgetType")] 
		public CUInt32 WidgetType
		{
			get => GetProperty(ref _widgetType);
			set => SetProperty(ref _widgetType, value);
		}

		[Ordinal(5)] 
		[RED("data")] 
		public CHandle<IScriptable> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}
	}
}
