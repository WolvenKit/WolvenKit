using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent : redEvent
	{
		private wCHandle<gameuiCharacterCustomizationOption> _option;

		[Ordinal(0)] 
		[RED("option")] 
		public wCHandle<gameuiCharacterCustomizationOption> Option
		{
			get => GetProperty(ref _option);
			set => SetProperty(ref _option, value);
		}

		public gameuiCharacterCustomizationSystem_OnOptionUpdatedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
