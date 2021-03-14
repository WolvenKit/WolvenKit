using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomLightAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _characterLocalLightRoughnesBias;

		[Ordinal(2)] 
		[RED("characterLocalLightRoughnesBias")] 
		public curveData<CFloat> CharacterLocalLightRoughnesBias
		{
			get
			{
				if (_characterLocalLightRoughnesBias == null)
				{
					_characterLocalLightRoughnesBias = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "characterLocalLightRoughnesBias", cr2w, this);
				}
				return _characterLocalLightRoughnesBias;
			}
			set
			{
				if (_characterLocalLightRoughnesBias == value)
				{
					return;
				}
				_characterLocalLightRoughnesBias = value;
				PropertySet(this);
			}
		}

		public CustomLightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
