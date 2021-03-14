using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JukeboxBigGameController : DeviceInkGameControllerBase
	{
		private CUInt32 _onTogglePlayListener;

		[Ordinal(16)] 
		[RED("onTogglePlayListener")] 
		public CUInt32 OnTogglePlayListener
		{
			get
			{
				if (_onTogglePlayListener == null)
				{
					_onTogglePlayListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onTogglePlayListener", cr2w, this);
				}
				return _onTogglePlayListener;
			}
			set
			{
				if (_onTogglePlayListener == value)
				{
					return;
				}
				_onTogglePlayListener = value;
				PropertySet(this);
			}
		}

		public JukeboxBigGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
