using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDeviceVisibilityChangedEvent : redEvent
	{
		private CUInt32 _isVisible;

		[Ordinal(0)] 
		[RED("isVisible")] 
		public CUInt32 IsVisible
		{
			get
			{
				if (_isVisible == null)
				{
					_isVisible = (CUInt32) CR2WTypeManager.Create("Uint32", "isVisible", cr2w, this);
				}
				return _isVisible;
			}
			set
			{
				if (_isVisible == value)
				{
					return;
				}
				_isVisible = value;
				PropertySet(this);
			}
		}

		public gameDeviceVisibilityChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
