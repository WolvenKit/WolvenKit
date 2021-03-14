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
			get
			{
				if (_material == null)
				{
					_material = (rRef<IMaterial>) CR2WTypeManager.Create("rRef:IMaterial", "material", cr2w, this);
				}
				return _material;
			}
			set
			{
				if (_material == value)
				{
					return;
				}
				_material = value;
				PropertySet(this);
			}
		}

		public gameEffectExecutor_OverrideMaterial(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
