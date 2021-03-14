using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkCallbackBase : CVariable
	{
		private CName _callbackName;
		private CArray<inkCallbackListener> _listeners;

		[Ordinal(0)] 
		[RED("callbackName")] 
		public CName CallbackName
		{
			get
			{
				if (_callbackName == null)
				{
					_callbackName = (CName) CR2WTypeManager.Create("CName", "callbackName", cr2w, this);
				}
				return _callbackName;
			}
			set
			{
				if (_callbackName == value)
				{
					return;
				}
				_callbackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("listeners")] 
		public CArray<inkCallbackListener> Listeners
		{
			get
			{
				if (_listeners == null)
				{
					_listeners = (CArray<inkCallbackListener>) CR2WTypeManager.Create("array:inkCallbackListener", "listeners", cr2w, this);
				}
				return _listeners;
			}
			set
			{
				if (_listeners == value)
				{
					return;
				}
				_listeners = value;
				PropertySet(this);
			}
		}

		public inkCallbackBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
