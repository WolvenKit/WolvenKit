using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSLastUsedWeapon : CVariable
	{
		private gameItemID _lastUsedWeapon;
		private gameItemID _lastUsedRanged;
		private gameItemID _lastUsedMelee;
		private gameItemID _lastUsedHeavy;

		[Ordinal(0)] 
		[RED("lastUsedWeapon")] 
		public gameItemID LastUsedWeapon
		{
			get
			{
				if (_lastUsedWeapon == null)
				{
					_lastUsedWeapon = (gameItemID) CR2WTypeManager.Create("gameItemID", "lastUsedWeapon", cr2w, this);
				}
				return _lastUsedWeapon;
			}
			set
			{
				if (_lastUsedWeapon == value)
				{
					return;
				}
				_lastUsedWeapon = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("lastUsedRanged")] 
		public gameItemID LastUsedRanged
		{
			get
			{
				if (_lastUsedRanged == null)
				{
					_lastUsedRanged = (gameItemID) CR2WTypeManager.Create("gameItemID", "lastUsedRanged", cr2w, this);
				}
				return _lastUsedRanged;
			}
			set
			{
				if (_lastUsedRanged == value)
				{
					return;
				}
				_lastUsedRanged = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("lastUsedMelee")] 
		public gameItemID LastUsedMelee
		{
			get
			{
				if (_lastUsedMelee == null)
				{
					_lastUsedMelee = (gameItemID) CR2WTypeManager.Create("gameItemID", "lastUsedMelee", cr2w, this);
				}
				return _lastUsedMelee;
			}
			set
			{
				if (_lastUsedMelee == value)
				{
					return;
				}
				_lastUsedMelee = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("lastUsedHeavy")] 
		public gameItemID LastUsedHeavy
		{
			get
			{
				if (_lastUsedHeavy == null)
				{
					_lastUsedHeavy = (gameItemID) CR2WTypeManager.Create("gameItemID", "lastUsedHeavy", cr2w, this);
				}
				return _lastUsedHeavy;
			}
			set
			{
				if (_lastUsedHeavy == value)
				{
					return;
				}
				_lastUsedHeavy = value;
				PropertySet(this);
			}
		}

		public gameSLastUsedWeapon(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
