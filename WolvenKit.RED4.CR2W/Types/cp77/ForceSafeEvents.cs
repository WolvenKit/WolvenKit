using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ForceSafeEvents : UpperBodyEventsTransition
	{
		private CHandle<AnimFeature_SafeAction> _safeAnimFeature;
		private TweakDBID _weaponObjectID;

		[Ordinal(6)] 
		[RED("safeAnimFeature")] 
		public CHandle<AnimFeature_SafeAction> SafeAnimFeature
		{
			get
			{
				if (_safeAnimFeature == null)
				{
					_safeAnimFeature = (CHandle<AnimFeature_SafeAction>) CR2WTypeManager.Create("handle:AnimFeature_SafeAction", "safeAnimFeature", cr2w, this);
				}
				return _safeAnimFeature;
			}
			set
			{
				if (_safeAnimFeature == value)
				{
					return;
				}
				_safeAnimFeature = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("weaponObjectID")] 
		public TweakDBID WeaponObjectID
		{
			get
			{
				if (_weaponObjectID == null)
				{
					_weaponObjectID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "weaponObjectID", cr2w, this);
				}
				return _weaponObjectID;
			}
			set
			{
				if (_weaponObjectID == value)
				{
					return;
				}
				_weaponObjectID = value;
				PropertySet(this);
			}
		}

		public ForceSafeEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
