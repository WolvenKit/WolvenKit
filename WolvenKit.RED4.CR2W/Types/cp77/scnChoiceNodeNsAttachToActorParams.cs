using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnChoiceNodeNsAttachToActorParams : CVariable
	{
		private scnActorId _actorId;
		private CEnum<scnChoiceNodeNsVisualizerStyle> _visualizerStyle;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
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

		public scnChoiceNodeNsAttachToActorParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
