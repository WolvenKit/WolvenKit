using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestUIEffectEvent : redEvent
	{
		private CBool _glitch;
		private CBool _panamVehicleStartup;
		private CBool _panamScreenType1;
		private CBool _panamScreenType2;
		private CBool _panamScreenType3;
		private CBool _panamScreenType4;

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

		[Ordinal(2)] 
		[RED("panamScreenType1")] 
		public CBool PanamScreenType1
		{
			get => GetProperty(ref _panamScreenType1);
			set => SetProperty(ref _panamScreenType1, value);
		}

		[Ordinal(3)] 
		[RED("panamScreenType2")] 
		public CBool PanamScreenType2
		{
			get => GetProperty(ref _panamScreenType2);
			set => SetProperty(ref _panamScreenType2, value);
		}

		[Ordinal(4)] 
		[RED("panamScreenType3")] 
		public CBool PanamScreenType3
		{
			get => GetProperty(ref _panamScreenType3);
			set => SetProperty(ref _panamScreenType3, value);
		}

		[Ordinal(5)] 
		[RED("panamScreenType4")] 
		public CBool PanamScreenType4
		{
			get => GetProperty(ref _panamScreenType4);
			set => SetProperty(ref _panamScreenType4, value);
		}

		public VehicleQuestUIEffectEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
