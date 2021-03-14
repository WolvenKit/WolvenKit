using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FridgeControllerPS : ScriptableDeviceComponentPS
	{
		private CBool _isOpen;

		[Ordinal(103)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get
			{
				if (_isOpen == null)
				{
					_isOpen = (CBool) CR2WTypeManager.Create("Bool", "isOpen", cr2w, this);
				}
				return _isOpen;
			}
			set
			{
				if (_isOpen == value)
				{
					return;
				}
				_isOpen = value;
				PropertySet(this);
			}
		}

		public FridgeControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
