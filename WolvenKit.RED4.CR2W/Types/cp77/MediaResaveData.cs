using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MediaResaveData : CVariable
	{
		private MediaDeviceData _mediaDeviceData;

		[Ordinal(0)] 
		[RED("mediaDeviceData")] 
		public MediaDeviceData MediaDeviceData
		{
			get
			{
				if (_mediaDeviceData == null)
				{
					_mediaDeviceData = (MediaDeviceData) CR2WTypeManager.Create("MediaDeviceData", "mediaDeviceData", cr2w, this);
				}
				return _mediaDeviceData;
			}
			set
			{
				if (_mediaDeviceData == value)
				{
					return;
				}
				_mediaDeviceData = value;
				PropertySet(this);
			}
		}

		public MediaResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
