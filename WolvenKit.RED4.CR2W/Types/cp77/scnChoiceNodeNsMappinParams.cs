using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsMappinParams : ISerializable
	{
		private CEnum<scnChoiceNodeNsMappinLocation> _locationType;
		private TweakDBID _mappinSettings;

		[Ordinal(0)] 
		[RED("locationType")] 
		public CEnum<scnChoiceNodeNsMappinLocation> LocationType
		{
			get => GetProperty(ref _locationType);
			set => SetProperty(ref _locationType, value);
		}

		[Ordinal(1)] 
		[RED("mappinSettings")] 
		public TweakDBID MappinSettings
		{
			get => GetProperty(ref _mappinSettings);
			set => SetProperty(ref _mappinSettings, value);
		}

		public scnChoiceNodeNsMappinParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
