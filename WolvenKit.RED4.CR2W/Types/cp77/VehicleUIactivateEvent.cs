using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleUIactivateEvent : redEvent
	{
		private CBool _activate;

		[Ordinal(0)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetProperty(ref _activate);
			set => SetProperty(ref _activate, value);
		}

		public VehicleUIactivateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
