using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameaudioeventsNotifySurfaceDirectionChanged : redEvent
	{
		private CEnum<gameaudioeventsSurfaceDirection> _surfaceDirection;

		[Ordinal(0)] 
		[RED("surfaceDirection")] 
		public CEnum<gameaudioeventsSurfaceDirection> SurfaceDirection
		{
			get
			{
				if (_surfaceDirection == null)
				{
					_surfaceDirection = (CEnum<gameaudioeventsSurfaceDirection>) CR2WTypeManager.Create("gameaudioeventsSurfaceDirection", "surfaceDirection", cr2w, this);
				}
				return _surfaceDirection;
			}
			set
			{
				if (_surfaceDirection == value)
				{
					return;
				}
				_surfaceDirection = value;
				PropertySet(this);
			}
		}

		public gameaudioeventsNotifySurfaceDirectionChanged(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
