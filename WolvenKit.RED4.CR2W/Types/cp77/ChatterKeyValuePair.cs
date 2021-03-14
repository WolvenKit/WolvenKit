using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChatterKeyValuePair : CVariable
	{
		private CRUID _key;
		private CHandle<ChatterLineLogicController> _value;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("Key")] 
		public CRUID Key
		{
			get
			{
				if (_key == null)
				{
					_key = (CRUID) CR2WTypeManager.Create("CRUID", "Key", cr2w, this);
				}
				return _key;
			}
			set
			{
				if (_key == value)
				{
					return;
				}
				_key = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("Value")] 
		public CHandle<ChatterLineLogicController> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (CHandle<ChatterLineLogicController>) CR2WTypeManager.Create("handle:ChatterLineLogicController", "Value", cr2w, this);
				}
				return _value;
			}
			set
			{
				if (_value == value)
				{
					return;
				}
				_value = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "Owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		public ChatterKeyValuePair(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
