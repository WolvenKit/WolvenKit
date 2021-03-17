using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForwardVehicleQuestUIEffectEvent : redEvent
	{
		private CBool _glitch;
		private CBool _panamVehicleStartup;

		[Ordinal(0)] 
		[RED("glitch")] 
		public CBool Glitch
		{
			get => GetProperty(ref _glitch);
			set => SetProperty(ref _glitch, value);
		}

		[Ordinal(1)] 
		[RED("panamVehicleStartup")] 
		public CBool PanamVehicleStartup
		{
			get => GetProperty(ref _panamVehicleStartup);
			set => SetProperty(ref _panamVehicleStartup, value);
		}

		public ForwardVehicleQuestUIEffectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
