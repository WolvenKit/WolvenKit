using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemOutputData : CVariable
	{
		private DeviceLink _link;
		private CEnum<EBreachOrigin> _breachOrigin;
		private CFloat _delayDuration;

		[Ordinal(0)] 
		[RED("link")] 
		public DeviceLink Link
		{
			get => GetProperty(ref _link);
			set => SetProperty(ref _link, value);
		}

		[Ordinal(1)] 
		[RED("breachOrigin")] 
		public CEnum<EBreachOrigin> BreachOrigin
		{
			get => GetProperty(ref _breachOrigin);
			set => SetProperty(ref _breachOrigin, value);
		}

		[Ordinal(2)] 
		[RED("delayDuration")] 
		public CFloat DelayDuration
		{
			get => GetProperty(ref _delayDuration);
			set => SetProperty(ref _delayDuration, value);
		}

		public SecuritySystemOutputData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
