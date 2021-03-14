using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetingLocalizedEffectComponent : entIComponent
	{
		private CFloat _streamingDistance;
		private CFloat _visibleTargetRange;

		[Ordinal(3)] 
		[RED("streamingDistance")] 
		public CFloat StreamingDistance
		{
			get
			{
				if (_streamingDistance == null)
				{
					_streamingDistance = (CFloat) CR2WTypeManager.Create("Float", "streamingDistance", cr2w, this);
				}
				return _streamingDistance;
			}
			set
			{
				if (_streamingDistance == value)
				{
					return;
				}
				_streamingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("visibleTargetRange")] 
		public CFloat VisibleTargetRange
		{
			get
			{
				if (_visibleTargetRange == null)
				{
					_visibleTargetRange = (CFloat) CR2WTypeManager.Create("Float", "visibleTargetRange", cr2w, this);
				}
				return _visibleTargetRange;
			}
			set
			{
				if (_visibleTargetRange == value)
				{
					return;
				}
				_visibleTargetRange = value;
				PropertySet(this);
			}
		}

		public gameTargetingLocalizedEffectComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
