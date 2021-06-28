using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entFootPlantedEvent : redEvent
	{
		private CName _customAction;
		private CEnum<animEventSide> _footSide;

		[Ordinal(0)] 
		[RED("customAction")] 
		public CName CustomAction
		{
			get => GetProperty(ref _customAction);
			set => SetProperty(ref _customAction, value);
		}

		[Ordinal(1)] 
		[RED("footSide")] 
		public CEnum<animEventSide> FootSide
		{
			get => GetProperty(ref _footSide);
			set => SetProperty(ref _footSide, value);
		}

		public entFootPlantedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
