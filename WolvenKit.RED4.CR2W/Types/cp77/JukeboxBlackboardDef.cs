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
			get
			{
				if (_isPlaying == null)
				{
					_isPlaying = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "IsPlaying", cr2w, this);
				}
				return _isPlaying;
			}
			set
			{
				if (_isPlaying == value)
				{
					return;
				}
				_isPlaying = value;
				PropertySet(this);
			}
		}

		public JukeboxBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
