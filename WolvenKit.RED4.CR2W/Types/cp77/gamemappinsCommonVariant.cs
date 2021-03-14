using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsCommonVariant : gamemappinsIPointOfInterestVariant
	{
		private TweakDBID _mappinType;
		private CEnum<gamedataMappinVariant> _variant;

		[Ordinal(0)] 
		[RED("mappinType")] 
		public TweakDBID MappinType
		{
			get
			{
				if (_mappinType == null)
				{
					_mappinType = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "mappinType", cr2w, this);
				}
				return _mappinType;
			}
			set
			{
				if (_mappinType == value)
				{
					return;
				}
				_mappinType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("variant")] 
		public CEnum<gamedataMappinVariant> Variant
		{
			get
			{
				if (_variant == null)
				{
					_variant = (CEnum<gamedataMappinVariant>) CR2WTypeManager.Create("gamedataMappinVariant", "variant", cr2w, this);
				}
				return _variant;
			}
			set
			{
				if (_variant == value)
				{
					return;
				}
				_variant = value;
				PropertySet(this);
			}
		}

		public gamemappinsCommonVariant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
