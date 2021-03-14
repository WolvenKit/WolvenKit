using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePingComponent : entIPlacedComponent
	{
		private CEnum<gamedataPingType> _associatedPingType;

		[Ordinal(5)] 
		[RED("associatedPingType")] 
		public CEnum<gamedataPingType> AssociatedPingType
		{
			get
			{
				if (_associatedPingType == null)
				{
					_associatedPingType = (CEnum<gamedataPingType>) CR2WTypeManager.Create("gamedataPingType", "associatedPingType", cr2w, this);
				}
				return _associatedPingType;
			}
			set
			{
				if (_associatedPingType == value)
				{
					return;
				}
				_associatedPingType = value;
				PropertySet(this);
			}
		}

		public gamePingComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
