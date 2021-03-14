using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateWeaponChargeEvent : redEvent
	{
		private CFloat _newValue;
		private CFloat _oldValue;

		[Ordinal(0)] 
		[RED("newValue")] 
		public CFloat NewValue
		{
			get
			{
				if (_newValue == null)
				{
					_newValue = (CFloat) CR2WTypeManager.Create("Float", "newValue", cr2w, this);
				}
				return _newValue;
			}
			set
			{
				if (_newValue == value)
				{
					return;
				}
				_newValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("oldValue")] 
		public CFloat OldValue
		{
			get
			{
				if (_oldValue == null)
				{
					_oldValue = (CFloat) CR2WTypeManager.Create("Float", "oldValue", cr2w, this);
				}
				return _oldValue;
			}
			set
			{
				if (_oldValue == value)
				{
					return;
				}
				_oldValue = value;
				PropertySet(this);
			}
		}

		public UpdateWeaponChargeEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
