using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickhackBarController : inkWidgetLogicController
	{
		private inkWidgetReference _emptyMask;
		private inkWidgetReference _empty;
		private inkWidgetReference _full;

		[Ordinal(1)] 
		[RED("emptyMask")] 
		public inkWidgetReference EmptyMask
		{
			get
			{
				if (_emptyMask == null)
				{
					_emptyMask = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "emptyMask", cr2w, this);
				}
				return _emptyMask;
			}
			set
			{
				if (_emptyMask == value)
				{
					return;
				}
				_emptyMask = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("empty")] 
		public inkWidgetReference Empty
		{
			get
			{
				if (_empty == null)
				{
					_empty = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "empty", cr2w, this);
				}
				return _empty;
			}
			set
			{
				if (_empty == value)
				{
					return;
				}
				_empty = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("full")] 
		public inkWidgetReference Full
		{
			get
			{
				if (_full == null)
				{
					_full = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "full", cr2w, this);
				}
				return _full;
			}
			set
			{
				if (_full == value)
				{
					return;
				}
				_full = value;
				PropertySet(this);
			}
		}

		public QuickhackBarController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
