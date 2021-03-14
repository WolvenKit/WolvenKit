using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToPropParams : CVariable
	{
		private scnPropId _propId;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
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

		public scnChoiceNodeNsAttachToPropParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
