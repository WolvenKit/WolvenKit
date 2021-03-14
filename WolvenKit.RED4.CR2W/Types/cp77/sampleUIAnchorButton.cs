using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIAnchorButton : inkWidgetLogicController
	{
		private CEnum<inkEAnchor> _anchorLocation;

		[Ordinal(1)] 
		[RED("anchorLocation")] 
		public CEnum<inkEAnchor> AnchorLocation
		{
			get
			{
				if (_anchorLocation == null)
				{
					_anchorLocation = (CEnum<inkEAnchor>) CR2WTypeManager.Create("inkEAnchor", "anchorLocation", cr2w, this);
				}
				return _anchorLocation;
			}
			set
			{
				if (_anchorLocation == value)
				{
					return;
				}
				_anchorLocation = value;
				PropertySet(this);
			}
		}

		public sampleUIAnchorButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
