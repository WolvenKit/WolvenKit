using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsSoundSwitch : redEvent
	{
		private CName _switchName;
		private CName _switchValue;

		[Ordinal(0)] 
		[RED("switchName")] 
		public CName SwitchName
		{
			get => GetProperty(ref _switchName);
			set => SetProperty(ref _switchName, value);
		}

		[Ordinal(1)] 
		[RED("switchValue")] 
		public CName SwitchValue
		{
			get => GetProperty(ref _switchValue);
			set => SetProperty(ref _switchValue, value);
		}

		public gameaudioeventsSoundSwitch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
