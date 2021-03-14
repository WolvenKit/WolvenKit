using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDeviceDelayedEvent : redEvent
	{
		private CInt32 _arrayIndex;
		private wCHandle<gameObject> _instigator;

		[Ordinal(0)] 
		[RED("arrayIndex")] 
		public CInt32 ArrayIndex
		{
			get
			{
				if (_arrayIndex == null)
				{
					_arrayIndex = (CInt32) CR2WTypeManager.Create("Int32", "arrayIndex", cr2w, this);
				}
				return _arrayIndex;
			}
			set
			{
				if (_arrayIndex == value)
				{
					return;
				}
				_arrayIndex = value;
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

		public ExplosiveDeviceDelayedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
