using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animOverrideBlendTrackInfo : CVariable
	{
		private animNamedTrackIndex _track;
		private CFloat _weight;

		[Ordinal(0)] 
		[RED("track")] 
		public animNamedTrackIndex Track
		{
			get
			{
				if (_track == null)
				{
					_track = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "track", cr2w, this);
				}
				return _track;
			}
			set
			{
				if (_track == value)
				{
					return;
				}
				_track = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		public animOverrideBlendTrackInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
