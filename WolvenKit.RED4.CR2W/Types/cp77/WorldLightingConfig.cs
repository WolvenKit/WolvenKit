using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldLightingConfig : CVariable
	{
		private CFloat _lightAttenuationClamp;

		[Ordinal(0)] 
		[RED("lightAttenuationClamp")] 
		public CFloat LightAttenuationClamp
		{
			get
			{
				if (_lightAttenuationClamp == null)
				{
					_lightAttenuationClamp = (CFloat) CR2WTypeManager.Create("Float", "lightAttenuationClamp", cr2w, this);
				}
				return _lightAttenuationClamp;
			}
			set
			{
				if (_lightAttenuationClamp == value)
				{
					return;
				}
				_lightAttenuationClamp = value;
				PropertySet(this);
			}
		}

		public WorldLightingConfig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
