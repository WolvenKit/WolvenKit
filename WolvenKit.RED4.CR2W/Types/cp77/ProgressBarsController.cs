using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarsController : inkWidgetLogicController
	{
		private inkWidgetReference _mask;

		[Ordinal(1)] 
		[RED("mask")] 
		public inkWidgetReference Mask
		{
			get
			{
				if (_mask == null)
				{
					_mask = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "mask", cr2w, this);
				}
				return _mask;
			}
			set
			{
				if (_mask == value)
				{
					return;
				}
				_mask = value;
				PropertySet(this);
			}
		}

		public ProgressBarsController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
