using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerSetup : CMaterialParameter
	{
		private rRef<Multilayer_Setup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public rRef<Multilayer_Setup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		public CMaterialParameterMultilayerSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
