using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMaterialOverride : CVariable
	{
		private CName _base;
		private CName _override;

		[Ordinal(0)] 
		[RED("base")] 
		public CName Base
		{
			get => GetProperty(ref _base);
			set => SetProperty(ref _base, value);
		}

		[Ordinal(1)] 
		[RED("override")] 
		public CName Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		public audioMaterialOverride(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
