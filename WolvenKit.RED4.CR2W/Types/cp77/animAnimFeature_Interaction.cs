using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Interaction : animAnimFeature
	{
		private CFloat _interactionDuration;
		private CInt32 _interactionStage;

		[Ordinal(0)] 
		[RED("interactionDuration")] 
		public CFloat InteractionDuration
		{
			get
			{
				if (_interactionDuration == null)
				{
					_interactionDuration = (CFloat) CR2WTypeManager.Create("Float", "interactionDuration", cr2w, this);
				}
				return _interactionDuration;
			}
			set
			{
				if (_interactionDuration == value)
				{
					return;
				}
				_interactionDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("interactionStage")] 
		public CInt32 InteractionStage
		{
			get
			{
				if (_interactionStage == null)
				{
					_interactionStage = (CInt32) CR2WTypeManager.Create("Int32", "interactionStage", cr2w, this);
				}
				return _interactionStage;
			}
			set
			{
				if (_interactionStage == value)
				{
					return;
				}
				_interactionStage = value;
				PropertySet(this);
			}
		}

		public animAnimFeature_Interaction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
