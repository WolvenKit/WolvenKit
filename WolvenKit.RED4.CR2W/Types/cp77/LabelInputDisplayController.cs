using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LabelInputDisplayController : inkInputDisplayController
	{
		private inkTextWidgetReference _inputLabel;

		[Ordinal(11)] 
		[RED("inputLabel")] 
		public inkTextWidgetReference InputLabel
		{
			get
			{
				if (_inputLabel == null)
				{
					_inputLabel = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "inputLabel", cr2w, this);
				}
				return _inputLabel;
			}
			set
			{
				if (_inputLabel == value)
				{
					return;
				}
				_inputLabel = value;
				PropertySet(this);
			}
		}

		public LabelInputDisplayController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
