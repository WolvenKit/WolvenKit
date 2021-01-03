using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CustomLightAreaSettings : IAreaSettings
	{
		[Ordinal(0)]  [RED("characterLocalLightRoughnesBias")] public curveData<CFloat> CharacterLocalLightRoughnesBias { get; set; }

		public CustomLightAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
