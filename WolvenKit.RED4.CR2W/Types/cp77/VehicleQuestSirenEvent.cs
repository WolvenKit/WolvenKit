using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestSirenEvent : redEvent
	{
		private CBool _lights;
		private CBool _sounds;

		[Ordinal(0)] 
		[RED("lights")] 
		public CBool Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}

		[Ordinal(1)] 
		[RED("sounds")] 
		public CBool Sounds
		{
			get => GetProperty(ref _sounds);
			set => SetProperty(ref _sounds, value);
		}

		public VehicleQuestSirenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
