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
			get
			{
				if (_lifepath == null)
				{
					_lifepath = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lifepath", cr2w, this);
				}
				return _lifepath;
			}
			set
			{
				if (_lifepath == value)
				{
					return;
				}
				_lifepath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("attributes")] 
		public CArray<gameuiCharacterCustomizationAttribute> Attributes
		{
			get
			{
				if (_attributes == null)
				{
					_attributes = (CArray<gameuiCharacterCustomizationAttribute>) CR2WTypeManager.Create("array:gameuiCharacterCustomizationAttribute", "attributes", cr2w, this);
				}
				return _attributes;
			}
			set
			{
				if (_attributes == value)
				{
					return;
				}
				_attributes = value;
				PropertySet(this);
			}
		}

		public gameuiSetCharacterCreationDataRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
