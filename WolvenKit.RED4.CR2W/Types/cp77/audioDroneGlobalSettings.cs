using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDroneGlobalSettings : audioAudioMetadata
	{
		private CName _speedRtpc;
		private CName _thrustRtpc;

		[Ordinal(1)] 
		[RED("speedRtpc")] 
		public CName SpeedRtpc
		{
			get
			{
				if (_speedRtpc == null)
				{
					_speedRtpc = (CName) CR2WTypeManager.Create("CName", "speedRtpc", cr2w, this);
				}
				return _speedRtpc;
			}
			set
			{
				if (_speedRtpc == value)
				{
					return;
				}
				_speedRtpc = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("thrustRtpc")] 
		public CName ThrustRtpc
		{
			get
			{
				if (_thrustRtpc == null)
				{
					_thrustRtpc = (CName) CR2WTypeManager.Create("CName", "thrustRtpc", cr2w, this);
				}
				return _thrustRtpc;
			}
			set
			{
				if (_thrustRtpc == value)
				{
					return;
				}
				_thrustRtpc = value;
				PropertySet(this);
			}
		}

		public audioDroneGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
