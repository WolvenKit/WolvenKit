using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputDeviceController : gameScriptableComponent
	{
		private CBool _isStarted;

		[Ordinal(5)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get
			{
				if (_isStarted == null)
				{
					_isStarted = (CBool) CR2WTypeManager.Create("Bool", "isStarted", cr2w, this);
				}
				return _isStarted;
			}
			set
			{
				if (_isStarted == value)
				{
					return;
				}
				_isStarted = value;
				PropertySet(this);
			}
		}

		public InputDeviceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
