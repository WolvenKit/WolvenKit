using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceAction : redEvent
	{
		private CName _actionName;
		private CInt32 _clearanceLevel;
		private CString _localizedObjectName;

		[Ordinal(0)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		[Ordinal(1)] 
		[RED("clearanceLevel")] 
		public CInt32 ClearanceLevel
		{
			get => GetProperty(ref _clearanceLevel);
			set => SetProperty(ref _clearanceLevel, value);
		}

		[Ordinal(2)] 
		[RED("localizedObjectName")] 
		public CString LocalizedObjectName
		{
			get => GetProperty(ref _localizedObjectName);
			set => SetProperty(ref _localizedObjectName, value);
		}

		public gamedeviceAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
