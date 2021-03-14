using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToWorldParams : CVariable
	{
		private Vector3 _entityPosition;
		private Quaternion _entityOrientation;
		private CFloat _customEntityRadius;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("entityPosition")] 
		public Vector3 EntityPosition
		{
			get
			{
				if (_entityPosition == null)
				{
					_entityPosition = (Vector3) CR2WTypeManager.Create("Vector3", "entityPosition", cr2w, this);
				}
				return _entityPosition;
			}
			set
			{
				if (_entityPosition == value)
				{
					return;
				}
				_entityPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("entityOrientation")] 
		public Quaternion EntityOrientation
		{
			get
			{
				if (_entityOrientation == null)
				{
					_entityOrientation = (Quaternion) CR2WTypeManager.Create("Quaternion", "entityOrientation", cr2w, this);
				}
				return _entityOrientation;
			}
			set
			{
				if (_entityOrientation == value)
				{
					return;
				}
				_entityOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("customEntityRadius")] 
		public CFloat CustomEntityRadius
		{
			get
			{
				if (_customEntityRadius == null)
				{
					_customEntityRadius = (CFloat) CR2WTypeManager.Create("Float", "customEntityRadius", cr2w, this);
				}
				return _customEntityRadius;
			}
			set
			{
				if (_customEntityRadius == value)
				{
					return;
				}
				_customEntityRadius = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("visualizerStyle")] 
		public CEnum<scnChoiceNodeNsVisualizerStyle> VisualizerStyle
		{
			get
			{
				if (_visualizerStyle == null)
				{
					_visualizerStyle = (CEnum<scnChoiceNodeNsVisualizerStyle>) CR2WTypeManager.Create("scnChoiceNodeNsVisualizerStyle", "visualizerStyle", cr2w, this);
				}
				return _visualizerStyle;
			}
			set
			{
				if (_visualizerStyle == value)
				{
					return;
				}
				_visualizerStyle = value;
				PropertySet(this);
			}
		}

		public scnChoiceNodeNsAttachToWorldParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
