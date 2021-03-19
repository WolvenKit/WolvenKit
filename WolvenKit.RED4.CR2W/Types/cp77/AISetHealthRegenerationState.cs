using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISetHealthRegenerationState : AIbehaviortaskScript
	{
		private CBool _healthRegeneration;

		[Ordinal(0)] 
		[RED("healthRegeneration")] 
		public CBool HealthRegeneration
		{
			get => GetProperty(ref _healthRegeneration);
			set => SetProperty(ref _healthRegeneration, value);
		}

		public AISetHealthRegenerationState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
