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
			get => GetProperty(ref _speedRtpc);
			set => SetProperty(ref _speedRtpc, value);
		}

		[Ordinal(2)] 
		[RED("thrustRtpc")] 
		public CName ThrustRtpc
		{
			get => GetProperty(ref _thrustRtpc);
			set => SetProperty(ref _thrustRtpc, value);
		}

		public audioDroneGlobalSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
