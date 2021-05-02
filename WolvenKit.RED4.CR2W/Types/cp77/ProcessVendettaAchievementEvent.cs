using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProcessVendettaAchievementEvent : redEvent
	{
		private wCHandle<gameObject> _deathInstigator;

		[Ordinal(0)] 
		[RED("deathInstigator")] 
		public wCHandle<gameObject> DeathInstigator
		{
			get => GetProperty(ref _deathInstigator);
			set => SetProperty(ref _deathInstigator, value);
		}

		public ProcessVendettaAchievementEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
