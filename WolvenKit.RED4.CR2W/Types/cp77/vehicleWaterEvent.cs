using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleWaterEvent : redEvent
	{
		private CBool _isInWater;

		[Ordinal(0)] 
		[RED("isInWater")] 
		public CBool IsInWater
		{
			get
			{
				if (_isInWater == null)
				{
					_isInWater = (CBool) CR2WTypeManager.Create("Bool", "isInWater", cr2w, this);
				}
				return _isInWater;
			}
			set
			{
				if (_isInWater == value)
				{
					return;
				}
				_isInWater = value;
				PropertySet(this);
			}
		}

		public vehicleWaterEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
