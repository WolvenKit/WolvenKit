using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PuppetDeviceLinkPS : DeviceLinkComponentPS
	{
		private SecuritySystemData _securitySystemData;

		[Ordinal(24)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetProperty(ref _securitySystemData);
			set => SetProperty(ref _securitySystemData, value);
		}

		public PuppetDeviceLinkPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
