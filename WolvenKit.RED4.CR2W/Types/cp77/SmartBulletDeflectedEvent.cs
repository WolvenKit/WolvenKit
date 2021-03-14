using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartBulletDeflectedEvent : redEvent
	{
		private CMatrix _localToWorld;
		private wCHandle<gameObject> _instigator;
		private wCHandle<gameObject> _weapon;

		[Ordinal(0)] 
		[RED("localToWorld")] 
		public CMatrix LocalToWorld
		{
			get
			{
				if (_localToWorld == null)
				{
					_localToWorld = (CMatrix) CR2WTypeManager.Create("Matrix", "localToWorld", cr2w, this);
				}
				return _localToWorld;
			}
			set
			{
				if (_localToWorld == value)
				{
					return;
				}
				_localToWorld = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("instigator")] 
		public wCHandle<gameObject> Instigator
		{
			get
			{
				if (_instigator == null)
				{
					_instigator = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "instigator", cr2w, this);
				}
				return _instigator;
			}
			set
			{
				if (_instigator == value)
				{
					return;
				}
				_instigator = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get
			{
				if (_weapon == null)
				{
					_weapon = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "weapon", cr2w, this);
				}
				return _weapon;
			}
			set
			{
				if (_weapon == value)
				{
					return;
				}
				_weapon = value;
				PropertySet(this);
			}
		}

		public SmartBulletDeflectedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
