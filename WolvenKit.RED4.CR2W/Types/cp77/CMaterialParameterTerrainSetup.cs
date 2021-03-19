using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterTerrainSetup : CMaterialParameter
	{
		private rRef<CTerrainSetup> _setup;

		[Ordinal(2)] 
		[RED("setup")] 
		public rRef<CTerrainSetup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		public CMaterialParameterTerrainSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
