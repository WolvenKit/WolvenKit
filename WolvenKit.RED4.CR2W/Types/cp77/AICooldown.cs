using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICooldown : AITimeCondition
	{
		private CFloat _cooldown;
		private CFloat _timestamp;

		[Ordinal(0)] 
		[RED("cooldown")] 
		public CFloat Cooldown
		{
			get => GetProperty(ref _cooldown);
			set => SetProperty(ref _cooldown, value);
		}

		[Ordinal(1)] 
		[RED("timestamp")] 
		public CFloat Timestamp
		{
			get => GetProperty(ref _timestamp);
			set => SetProperty(ref _timestamp, value);
		}

		public AICooldown(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
