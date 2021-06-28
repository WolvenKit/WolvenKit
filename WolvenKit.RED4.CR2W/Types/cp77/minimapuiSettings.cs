using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapuiSettings : CVariable
	{
		private CFloat _showTime;
		private CFloat _hideTime;

		[Ordinal(0)] 
		[RED("showTime")] 
		public CFloat ShowTime
		{
			get => GetProperty(ref _showTime);
			set => SetProperty(ref _showTime, value);
		}

		[Ordinal(1)] 
		[RED("hideTime")] 
		public CFloat HideTime
		{
			get => GetProperty(ref _hideTime);
			set => SetProperty(ref _hideTime, value);
		}

		public minimapuiSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
