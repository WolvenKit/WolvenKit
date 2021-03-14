using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkStepperData : CVariable
	{
		private CString _label;
		private wCHandle<IScriptable> _data;

		[Ordinal(0)] 
		[RED("label")] 
		public CString Label
		{
			get
			{
				if (_label == null)
				{
					_label = (CString) CR2WTypeManager.Create("String", "label", cr2w, this);
				}
				return _label;
			}
			set
			{
				if (_label == value)
				{
					return;
				}
				_label = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("data")] 
		public wCHandle<IScriptable> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public inkStepperData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
