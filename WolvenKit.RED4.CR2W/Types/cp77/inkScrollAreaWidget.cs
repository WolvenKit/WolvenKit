using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkScrollAreaWidget : inkCompoundWidget
	{
		private CFloat _horizontalScrolling;
		private CFloat _verticalScrolling;
		private CBool _constrainContentPosition;
		private CEnum<inkFitToContentDirection> _fitToContentDirection;
		private CBool _useInternalMask;

		[Ordinal(23)] 
		[RED("horizontalScrolling")] 
		public CFloat HorizontalScrolling
		{
			get
			{
				if (_horizontalScrolling == null)
				{
					_horizontalScrolling = (CFloat) CR2WTypeManager.Create("Float", "horizontalScrolling", cr2w, this);
				}
				return _horizontalScrolling;
			}
			set
			{
				if (_horizontalScrolling == value)
				{
					return;
				}
				_horizontalScrolling = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("verticalScrolling")] 
		public CFloat VerticalScrolling
		{
			get
			{
				if (_verticalScrolling == null)
				{
					_verticalScrolling = (CFloat) CR2WTypeManager.Create("Float", "verticalScrolling", cr2w, this);
				}
				return _verticalScrolling;
			}
			set
			{
				if (_verticalScrolling == value)
				{
					return;
				}
				_verticalScrolling = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("constrainContentPosition")] 
		public CBool ConstrainContentPosition
		{
			get
			{
				if (_constrainContentPosition == null)
				{
					_constrainContentPosition = (CBool) CR2WTypeManager.Create("Bool", "constrainContentPosition", cr2w, this);
				}
				return _constrainContentPosition;
			}
			set
			{
				if (_constrainContentPosition == value)
				{
					return;
				}
				_constrainContentPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("fitToContentDirection")] 
		public CEnum<inkFitToContentDirection> FitToContentDirection
		{
			get
			{
				if (_fitToContentDirection == null)
				{
					_fitToContentDirection = (CEnum<inkFitToContentDirection>) CR2WTypeManager.Create("inkFitToContentDirection", "fitToContentDirection", cr2w, this);
				}
				return _fitToContentDirection;
			}
			set
			{
				if (_fitToContentDirection == value)
				{
					return;
				}
				_fitToContentDirection = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("useInternalMask")] 
		public CBool UseInternalMask
		{
			get
			{
				if (_useInternalMask == null)
				{
					_useInternalMask = (CBool) CR2WTypeManager.Create("Bool", "useInternalMask", cr2w, this);
				}
				return _useInternalMask;
			}
			set
			{
				if (_useInternalMask == value)
				{
					return;
				}
				_useInternalMask = value;
				PropertySet(this);
			}
		}

		public inkScrollAreaWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
