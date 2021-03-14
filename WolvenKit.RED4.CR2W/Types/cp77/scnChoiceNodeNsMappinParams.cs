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
			get
			{
				if (_locationType == null)
				{
					_locationType = (CEnum<scnChoiceNodeNsMappinLocation>) CR2WTypeManager.Create("scnChoiceNodeNsMappinLocation", "locationType", cr2w, this);
				}
				return _locationType;
			}
			set
			{
				if (_locationType == value)
				{
					return;
				}
				_locationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("mappinSettings")] 
		public TweakDBID MappinSettings
		{
			get
			{
				if (_mappinSettings == null)
				{
					_mappinSettings = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mappinSettings", cr2w, this);
				}
				return _mappinSettings;
			}
			set
			{
				if (_mappinSettings == value)
				{
					return;
				}
				_mappinSettings = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsMappinParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
