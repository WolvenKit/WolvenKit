using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetrunnerChairControllerPS : ScriptableDeviceComponentPS
	{
		private CFloat _killDelay;

		[Ordinal(103)] 
		[RED("killDelay")] 
		public CFloat KillDelay
		{
			get => GetProperty(ref _killDelay);
			set => SetProperty(ref _killDelay, value);
		}

		public NetrunnerChairControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
