using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Bool _isPlaying;

		[Ordinal(7)] 
		[RED("IsPlaying")] 
		public gamebbScriptID_Bool IsPlaying
		{
			get => GetProperty(ref _isPlaying);
			set => SetProperty(ref _isPlaying, value);
		}

		public JukeboxBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
