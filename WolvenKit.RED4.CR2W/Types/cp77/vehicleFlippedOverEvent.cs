using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleFlippedOverEvent : redEvent
	{
		private CBool _isFlippedOver;

		[Ordinal(0)] 
		[RED("isFlippedOver")] 
		public CBool IsFlippedOver
		{
			get
			{
				if (_isFlippedOver == null)
				{
					_isFlippedOver = (CBool) CR2WTypeManager.Create("Bool", "isFlippedOver", cr2w, this);
				}
				return _isFlippedOver;
			}
			set
			{
				if (_isFlippedOver == value)
				{
					return;
				}
				_isFlippedOver = value;
				PropertySet(this);
			}
		}

		public vehicleFlippedOverEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
