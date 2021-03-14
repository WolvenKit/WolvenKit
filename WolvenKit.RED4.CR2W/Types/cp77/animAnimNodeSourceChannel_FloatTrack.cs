using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNodeSourceChannel_FloatTrack : animIAnimNodeSourceChannel_Float
	{
		private animNamedTrackIndex _floatTrack;
		private CBool _useComplementValue;

		[Ordinal(0)] 
		[RED("floatTrack")] 
		public animNamedTrackIndex FloatTrack
		{
			get
			{
				if (_floatTrack == null)
				{
					_floatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "floatTrack", cr2w, this);
				}
				return _floatTrack;
			}
			set
			{
				if (_floatTrack == value)
				{
					return;
				}
				_floatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("useComplementValue")] 
		public CBool UseComplementValue
		{
			get
			{
				if (_useComplementValue == null)
				{
					_useComplementValue = (CBool) CR2WTypeManager.Create("Bool", "useComplementValue", cr2w, this);
				}
				return _useComplementValue;
			}
			set
			{
				if (_useComplementValue == value)
				{
					return;
				}
				_useComplementValue = value;
				PropertySet(this);
			}
		}

		public animAnimNodeSourceChannel_FloatTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
