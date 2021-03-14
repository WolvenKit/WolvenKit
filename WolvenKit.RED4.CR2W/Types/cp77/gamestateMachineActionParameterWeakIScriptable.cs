using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineActionParameterWeakIScriptable : CVariable
	{
		private CName _name;
		private wCHandle<IScriptable> _value;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("value")] 
		public wCHandle<IScriptable> Value
		{
			get
			{
				if (_value == null)
				{
					_value = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "value", cr2w, this);
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

		public gamestateMachineActionParameterWeakIScriptable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
