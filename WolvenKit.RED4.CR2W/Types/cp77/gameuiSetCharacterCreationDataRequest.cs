using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSetCharacterCreationDataRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _lifepath;
		private CArray<gameuiCharacterCustomizationAttribute> _attributes;

		[Ordinal(1)] 
		[RED("lifepath")] 
		public TweakDBID Lifepath
		{
			get => GetProperty(ref _lifepath);
			set => SetProperty(ref _lifepath, value);
		}

		[Ordinal(2)] 
		[RED("attributes")] 
		public CArray<gameuiCharacterCustomizationAttribute> Attributes
		{
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		public gameuiSetCharacterCreationDataRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
