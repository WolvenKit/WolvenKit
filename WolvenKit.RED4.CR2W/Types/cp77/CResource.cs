using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CResource : ISerializable
	{
		private CEnum<ECookingPlatform> _cookingPlatform;

		[Ordinal(0)] 
		[RED("cookingPlatform")] 
		public CEnum<ECookingPlatform> CookingPlatform
		{
			get
			{
				if (_cookingPlatform == null)
				{
					_cookingPlatform = (CEnum<ECookingPlatform>) CR2WTypeManager.Create("ECookingPlatform", "cookingPlatform", cr2w, this);
				}
				return _cookingPlatform;
			}
			set
			{
				if (_cookingPlatform == value)
				{
					return;
				}
				_cookingPlatform = value;
				PropertySet(this);
			}
		}

		public CResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
