using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimingStateDecisions : UpperBodyTransition
	{
		private CFloat _mouseZoomLevel;

		[Ordinal(0)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get
			{
				if (_mouseZoomLevel == null)
				{
					_mouseZoomLevel = (CFloat) CR2WTypeManager.Create("Float", "mouseZoomLevel", cr2w, this);
				}
				return _mouseZoomLevel;
			}
			set
			{
				if (_mouseZoomLevel == value)
				{
					return;
				}
				_mouseZoomLevel = value;
				PropertySet(this);
			}
		}

		public AimingStateDecisions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
