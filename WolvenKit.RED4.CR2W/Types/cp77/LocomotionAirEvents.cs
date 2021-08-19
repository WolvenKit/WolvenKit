using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LocomotionAirEvents : LocomotionEventsTransition
	{
		private CBool _maxSuperheroFallHeight;
		private CBool _updateInputToggles;

		[Ordinal(3)] 
		[RED("maxSuperheroFallHeight")] 
		public CBool MaxSuperheroFallHeight
		{
			get => GetProperty(ref _maxSuperheroFallHeight);
			set => SetProperty(ref _maxSuperheroFallHeight, value);
		}

		[Ordinal(4)] 
		[RED("updateInputToggles")] 
		public CBool UpdateInputToggles
		{
			get => GetProperty(ref _updateInputToggles);
			set => SetProperty(ref _updateInputToggles, value);
		}

		public LocomotionAirEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
