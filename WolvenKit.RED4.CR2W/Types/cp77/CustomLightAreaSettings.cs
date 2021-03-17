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
			get => GetProperty(ref _characterLocalLightRoughnesBias);
			set => SetProperty(ref _characterLocalLightRoughnesBias, value);
		}

		public CustomLightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
