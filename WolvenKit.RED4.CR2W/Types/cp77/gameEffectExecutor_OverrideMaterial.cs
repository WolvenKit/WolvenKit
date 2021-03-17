using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectExecutor_OverrideMaterial : gameEffectExecutor
	{
		private rRef<IMaterial> _material;

		[Ordinal(1)] 
		[RED("material")] 
		public rRef<IMaterial> Material
		{
			get => GetProperty(ref _material);
			set => SetProperty(ref _material, value);
		}

		public gameEffectExecutor_OverrideMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
