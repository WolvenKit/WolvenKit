using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BossHealthStatListener : gameScriptStatPoolsListener
	{
		private wCHandle<BossHealthBarGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public wCHandle<BossHealthBarGameController> Healthbar
		{
			get => GetProperty(ref _healthbar);
			set => SetProperty(ref _healthbar, value);
		}

		public BossHealthStatListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
