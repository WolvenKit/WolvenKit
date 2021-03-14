using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToGameObjectParams : CVariable
	{
		private NodeRef _nodeRef;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		public scnChoiceNodeNsAttachToGameObjectParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
