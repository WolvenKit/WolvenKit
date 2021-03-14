using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricLight : Device
	{
		private CArray<CHandle<gameLightComponent>> _lightComponents;
		private CArray<gamedataLightPreset> _lightDefinitions;

		[Ordinal(86)] 
		[RED("lightComponents")] 
		public CArray<CHandle<gameLightComponent>> LightComponents
		{
			get
			{
				if (_lightComponents == null)
				{
					_lightComponents = (CArray<CHandle<gameLightComponent>>) CR2WTypeManager.Create("array:handle:gameLightComponent", "lightComponents", cr2w, this);
				}
				return _lightComponents;
			}
			set
			{
				if (_lightComponents == value)
				{
					return;
				}
				_lightComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(87)] 
		[RED("lightDefinitions")] 
		public CArray<gamedataLightPreset> LightDefinitions
		{
			get
			{
				if (_lightDefinitions == null)
				{
					_lightDefinitions = (CArray<gamedataLightPreset>) CR2WTypeManager.Create("array:gamedataLightPreset", "lightDefinitions", cr2w, this);
				}
				return _lightDefinitions;
			}
			set
			{
				if (_lightDefinitions == value)
				{
					return;
				}
				_lightDefinitions = value;
				PropertySet(this);
			}
		}

		public ElectricLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
