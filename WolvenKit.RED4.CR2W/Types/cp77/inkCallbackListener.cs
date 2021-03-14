using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackListener : CVariable
	{
		private wCHandle<IScriptable> _object;
		private CName _functionName;

		[Ordinal(0)] 
		[RED("object")] 
		public wCHandle<IScriptable> Object
		{
			get
			{
				if (_object == null)
				{
					_object = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "object", cr2w, this);
				}
				return _object;
			}
			set
			{
				if (_object == value)
				{
					return;
				}
				_object = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("functionName")] 
		public CName FunctionName
		{
			get
			{
				if (_functionName == null)
				{
					_functionName = (CName) CR2WTypeManager.Create("CName", "functionName", cr2w, this);
				}
				return _functionName;
			}
			set
			{
				if (_functionName == value)
				{
					return;
				}
				_functionName = value;
				PropertySet(this);
			}
		}

		public inkCallbackListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
