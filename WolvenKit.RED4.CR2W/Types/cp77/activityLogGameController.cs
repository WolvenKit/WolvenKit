using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class activityLogGameController : gameuiHUDGameController
	{
		private CInt32 _readIndex;
		private CInt32 _writeIndex;
		private CInt32 _maxSize;
		private CArray<CString> _entries;
		private inkVerticalPanelWidgetReference _panel;
		private CHandle<redCallbackObject> _onNewEntries;
		private CHandle<redCallbackObject> _onHide;

		[Ordinal(9)] 
		[RED("readIndex")] 
		public CInt32 ReadIndex
		{
			get => GetProperty(ref _readIndex);
			set => SetProperty(ref _readIndex, value);
		}

		[Ordinal(10)] 
		[RED("writeIndex")] 
		public CInt32 WriteIndex
		{
			get => GetProperty(ref _writeIndex);
			set => SetProperty(ref _writeIndex, value);
		}

		[Ordinal(11)] 
		[RED("maxSize")] 
		public CInt32 MaxSize
		{
			get => GetProperty(ref _maxSize);
			set => SetProperty(ref _maxSize, value);
		}

		[Ordinal(12)] 
		[RED("entries")] 
		public CArray<CString> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}

		[Ordinal(13)] 
		[RED("panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetProperty(ref _panel);
			set => SetProperty(ref _panel, value);
		}

		[Ordinal(14)] 
		[RED("onNewEntries")] 
		public CHandle<redCallbackObject> OnNewEntries
		{
			get => GetProperty(ref _onNewEntries);
			set => SetProperty(ref _onNewEntries, value);
		}

		[Ordinal(15)] 
		[RED("onHide")] 
		public CHandle<redCallbackObject> OnHide
		{
			get => GetProperty(ref _onHide);
			set => SetProperty(ref _onHide, value);
		}

		public activityLogGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
