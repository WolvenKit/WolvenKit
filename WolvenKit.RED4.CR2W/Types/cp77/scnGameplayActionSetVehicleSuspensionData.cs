using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGameplayActionSetVehicleSuspensionData : scnIGameplayActionData
	{
		private CBool _active;
		private CFloat _cooldownTime;

		[Ordinal(0)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(1)] 
		[RED("cooldownTime")] 
		public CFloat CooldownTime
		{
			get => GetProperty(ref _cooldownTime);
			set => SetProperty(ref _cooldownTime, value);
		}

		public scnGameplayActionSetVehicleSuspensionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
