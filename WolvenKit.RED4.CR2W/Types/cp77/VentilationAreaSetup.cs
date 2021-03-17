using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VentilationAreaSetup : CVariable
	{
		private CEnum<ETrapEffects> _areaEffect;
		private CName _actionName;

		[Ordinal(0)] 
		[RED("areaEffect")] 
		public CEnum<ETrapEffects> AreaEffect
		{
			get => GetProperty(ref _areaEffect);
			set => SetProperty(ref _areaEffect, value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CName ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public VentilationAreaSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
