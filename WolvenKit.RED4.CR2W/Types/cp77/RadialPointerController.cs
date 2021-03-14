using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadialPointerController : inkWidgetLogicController
	{
		private inkImageWidgetReference _pointer;
		private inkImageWidgetReference _feedback;

		[Ordinal(1)] 
		[RED("pointer")] 
		public inkImageWidgetReference Pointer
		{
			get
			{
				if (_pointer == null)
				{
					_pointer = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "pointer", cr2w, this);
				}
				return _pointer;
			}
			set
			{
				if (_pointer == value)
				{
					return;
				}
				_pointer = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("feedback")] 
		public inkImageWidgetReference Feedback
		{
			get
			{
				if (_feedback == null)
				{
					_feedback = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "feedback", cr2w, this);
				}
				return _feedback;
			}
			set
			{
				if (_feedback == value)
				{
					return;
				}
				_feedback = value;
				PropertySet(this);
			}
		}

		public RadialPointerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
