using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRootHudGameController : gameuiWidgetGameController
	{
		private CArray<inkCompoundWidgetReference> _resolutionSensitiveRoots;

		[Ordinal(2)] 
		[RED("resolutionSensitiveRoots")] 
		public CArray<inkCompoundWidgetReference> ResolutionSensitiveRoots
		{
			get
			{
				if (_resolutionSensitiveRoots == null)
				{
					_resolutionSensitiveRoots = (CArray<inkCompoundWidgetReference>) CR2WTypeManager.Create("array:inkCompoundWidgetReference", "resolutionSensitiveRoots", cr2w, this);
				}
				return _resolutionSensitiveRoots;
			}
			set
			{
				if (_resolutionSensitiveRoots == value)
				{
					return;
				}
				_resolutionSensitiveRoots = value;
				PropertySet(this);
			}
		}

		public gameuiRootHudGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
