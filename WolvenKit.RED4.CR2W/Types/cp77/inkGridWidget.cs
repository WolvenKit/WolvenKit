using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkGridWidget : inkCompoundWidget
	{
		private CEnum<inkEOrientation> _orientation;
		private inkMargin _childPadding;
		private Vector2 _childSizeStep;

		[Ordinal(23)] 
		[RED("orientation")] 
		public CEnum<inkEOrientation> Orientation
		{
			get
			{
				if (_orientation == null)
				{
					_orientation = (CEnum<inkEOrientation>) CR2WTypeManager.Create("inkEOrientation", "orientation", cr2w, this);
				}
				return _orientation;
			}
			set
			{
				if (_orientation == value)
				{
					return;
				}
				_orientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("childPadding")] 
		public inkMargin ChildPadding
		{
			get
			{
				if (_childPadding == null)
				{
					_childPadding = (inkMargin) CR2WTypeManager.Create("inkMargin", "childPadding", cr2w, this);
				}
				return _childPadding;
			}
			set
			{
				if (_childPadding == value)
				{
					return;
				}
				_childPadding = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("childSizeStep")] 
		public Vector2 ChildSizeStep
		{
			get
			{
				if (_childSizeStep == null)
				{
					_childSizeStep = (Vector2) CR2WTypeManager.Create("Vector2", "childSizeStep", cr2w, this);
				}
				return _childSizeStep;
			}
			set
			{
				if (_childSizeStep == value)
				{
					return;
				}
				_childSizeStep = value;
				PropertySet(this);
			}
		}

		public inkGridWidget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
