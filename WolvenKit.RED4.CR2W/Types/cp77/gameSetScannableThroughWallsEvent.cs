using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSetScannableThroughWallsEvent : redEvent
	{
		private CBool _isScannableThroughWalls;

		[Ordinal(0)] 
		[RED("isScannableThroughWalls")] 
		public CBool IsScannableThroughWalls
		{
			get
			{
				if (_isScannableThroughWalls == null)
				{
					_isScannableThroughWalls = (CBool) CR2WTypeManager.Create("Bool", "isScannableThroughWalls", cr2w, this);
				}
				return _isScannableThroughWalls;
			}
			set
			{
				if (_isScannableThroughWalls == value)
				{
					return;
				}
				_isScannableThroughWalls = value;
				PropertySet(this);
			}
		}

		public gameSetScannableThroughWallsEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
