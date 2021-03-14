using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSimpleBounceTrackOutput : CVariable
	{
		private animNamedTrackIndex _targetTrack;
		private CFloat _multiplier;

		[Ordinal(0)] 
		[RED("targetTrack")] 
		public animNamedTrackIndex TargetTrack
		{
			get
			{
				if (_targetTrack == null)
				{
					_targetTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "targetTrack", cr2w, this);
				}
				return _targetTrack;
			}
			set
			{
				if (_targetTrack == value)
				{
					return;
				}
				_targetTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get
			{
				if (_multiplier == null)
				{
					_multiplier = (CFloat) CR2WTypeManager.Create("Float", "multiplier", cr2w, this);
				}
				return _multiplier;
			}
			set
			{
				if (_multiplier == value)
				{
					return;
				}
				_multiplier = value;
				PropertySet(this);
			}
		}

		public animSimpleBounceTrackOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
