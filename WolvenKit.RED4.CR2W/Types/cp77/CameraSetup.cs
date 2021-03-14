using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraSetup : CVariable
	{
		private CBool _canStreamVideo;

		[Ordinal(0)] 
		[RED("canStreamVideo")] 
		public CBool CanStreamVideo
		{
			get
			{
				if (_canStreamVideo == null)
				{
					_canStreamVideo = (CBool) CR2WTypeManager.Create("Bool", "canStreamVideo", cr2w, this);
				}
				return _canStreamVideo;
			}
			set
			{
				if (_canStreamVideo == value)
				{
					return;
				}
				_canStreamVideo = value;
				PropertySet(this);
			}
		}

		public CameraSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
