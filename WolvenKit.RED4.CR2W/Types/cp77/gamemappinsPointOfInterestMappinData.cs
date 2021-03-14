using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamemappinsPointOfInterestMappinData : gamemappinsIMappinData
	{
		private CHandle<gamemappinsIPointOfInterestVariant> _typedVariant;
		private CBool _active;

		[Ordinal(0)] 
		[RED("typedVariant")] 
		public CHandle<gamemappinsIPointOfInterestVariant> TypedVariant
		{
			get
			{
				if (_typedVariant == null)
				{
					_typedVariant = (CHandle<gamemappinsIPointOfInterestVariant>) CR2WTypeManager.Create("handle:gamemappinsIPointOfInterestVariant", "typedVariant", cr2w, this);
				}
				return _typedVariant;
			}
			set
			{
				if (_typedVariant == value)
				{
					return;
				}
				_typedVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		public gamemappinsPointOfInterestMappinData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
