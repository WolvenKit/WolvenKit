using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseDirectionalIndicatorPartLogicController : inkWidgetLogicController
	{
		private CFloat _defaultForwardFovRange;
		private CFloat _adjustedForwardFovRange;

		[Ordinal(1)] 
		[RED("defaultForwardFovRange")] 
		public CFloat DefaultForwardFovRange
		{
			get
			{
				if (_defaultForwardFovRange == null)
				{
					_defaultForwardFovRange = (CFloat) CR2WTypeManager.Create("Float", "defaultForwardFovRange", cr2w, this);
				}
				return _defaultForwardFovRange;
			}
			set
			{
				if (_defaultForwardFovRange == value)
				{
					return;
				}
				_defaultForwardFovRange = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("adjustedForwardFovRange")] 
		public CFloat AdjustedForwardFovRange
		{
			get
			{
				if (_adjustedForwardFovRange == null)
				{
					_adjustedForwardFovRange = (CFloat) CR2WTypeManager.Create("Float", "adjustedForwardFovRange", cr2w, this);
				}
				return _adjustedForwardFovRange;
			}
			set
			{
				if (_adjustedForwardFovRange == value)
				{
					return;
				}
				_adjustedForwardFovRange = value;
				PropertySet(this);
			}
		}

		public gameuiBaseDirectionalIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
