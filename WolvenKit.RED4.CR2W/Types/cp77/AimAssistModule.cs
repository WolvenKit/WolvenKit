using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAssistModule : HUDModule
	{
		private CArray<CHandle<AimAssist>> _activeAssists;

		[Ordinal(3)] 
		[RED("activeAssists")] 
		public CArray<CHandle<AimAssist>> ActiveAssists
		{
			get => GetProperty(ref _activeAssists);
			set => SetProperty(ref _activeAssists, value);
		}

		public AimAssistModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
