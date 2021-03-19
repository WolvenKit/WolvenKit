using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGodModeEntityData : CVariable
	{
		private CArray<gameGodModeData> _overrides;
		private CArray<gameGodModeData> _base;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<gameGodModeData> Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		[Ordinal(1)] 
		[RED("base")] 
		public CArray<gameGodModeData> Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}

		public gameGodModeEntityData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
