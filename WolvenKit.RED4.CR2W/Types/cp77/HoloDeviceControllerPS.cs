using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HoloDeviceControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isPlaying;

		[Ordinal(103)] 
		[RED("isPlaying")] 
		public CBool IsPlaying
		{
			get
			{
				if (_isPlaying == null)
				{
					_isPlaying = (CBool) CR2WTypeManager.Create("Bool", "isPlaying", cr2w, this);
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

		public HoloDeviceControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
