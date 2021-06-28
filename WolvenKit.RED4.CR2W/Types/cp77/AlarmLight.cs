using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AlarmLight : BasicDistractionDevice
	{
		private CBool _isGlitching;

		[Ordinal(102)] 
		[RED("isGlitching")] 
		public CBool IsGlitching
		{
			get => GetProperty(ref _isGlitching);
			set => SetProperty(ref _isGlitching, value);
		}

		public AlarmLight(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
