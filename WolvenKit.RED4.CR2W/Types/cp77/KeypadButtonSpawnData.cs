using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class KeypadButtonSpawnData : IScriptable
	{
		private CName _widgetName;
		private CString _locKey;
		private CBool _isActionButton;
		private SDeviceWidgetPackage _widgetData;

		[Ordinal(0)] 
		[RED("widgetName")] 
		public CName WidgetName
		{
			get => GetProperty(ref _widgetName);
			set => SetProperty(ref _widgetName, value);
		}

		[Ordinal(1)] 
		[RED("locKey")] 
		public CString LocKey
		{
			get => GetProperty(ref _locKey);
			set => SetProperty(ref _locKey, value);
		}

		[Ordinal(2)] 
		[RED("isActionButton")] 
		public CBool IsActionButton
		{
			get => GetProperty(ref _isActionButton);
			set => SetProperty(ref _isActionButton, value);
		}

		[Ordinal(3)] 
		[RED("widgetData")] 
		public SDeviceWidgetPackage WidgetData
		{
			get => GetProperty(ref _widgetData);
			set => SetProperty(ref _widgetData, value);
		}

		public KeypadButtonSpawnData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
