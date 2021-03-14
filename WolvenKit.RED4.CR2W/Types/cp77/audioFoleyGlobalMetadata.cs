using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		private CFloat _fadeoutTime;
		private CName _fadeoutRtpc;

		[Ordinal(1)] 
		[RED("fadeoutTime")] 
		public CFloat FadeoutTime
		{
			get
			{
				if (_fadeoutTime == null)
				{
					_fadeoutTime = (CFloat) CR2WTypeManager.Create("Float", "fadeoutTime", cr2w, this);
				}
				return _fadeoutTime;
			}
			set
			{
				if (_fadeoutTime == value)
				{
					return;
				}
				_fadeoutTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fadeoutRtpc")] 
		public CName FadeoutRtpc
		{
			get
			{
				if (_fadeoutRtpc == null)
				{
					_fadeoutRtpc = (CName) CR2WTypeManager.Create("CName", "fadeoutRtpc", cr2w, this);
				}
				return _fadeoutRtpc;
			}
			set
			{
				if (_fadeoutRtpc == value)
				{
					return;
				}
				_fadeoutRtpc = value;
				PropertySet(this);
			}
		}

		public audioFoleyGlobalMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
