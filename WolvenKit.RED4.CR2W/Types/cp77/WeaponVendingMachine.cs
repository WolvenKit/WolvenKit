using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachine : VendingMachine
	{
		private wCHandle<IWorldWidgetComponent> _bigAdScreen;

		[Ordinal(101)] 
		[RED("bigAdScreen")] 
		public wCHandle<IWorldWidgetComponent> BigAdScreen
		{
			get => GetProperty(ref _bigAdScreen);
			set => SetProperty(ref _bigAdScreen, value);
		}

		public WeaponVendingMachine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
