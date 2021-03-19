using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VirutalNestedListData : IScriptable
	{
		private CBool _collapsable;
		private CBool _isHeader;
		private CInt32 _level;
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
		[RED("widgetType")] 
		public CUInt32 WidgetType
		{
			get => GetProperty(ref _widgetType);
			set => SetProperty(ref _widgetType, value);
		}

		[Ordinal(4)] 
		[RED("data")] 
		public CHandle<IScriptable> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		public VirutalNestedListData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
