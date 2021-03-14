using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReverbCrossoverParams : CVariable
	{
		private CFloat _dist;
		private CFloat _fade;

		[Ordinal(0)] 
		[RED("dist")] 
		public CFloat Dist
		{
			get
			{
				if (_dist == null)
				{
					_dist = (CFloat) CR2WTypeManager.Create("Float", "dist", cr2w, this);
				}
				return _dist;
			}
			set
			{
				if (_dist == value)
				{
					return;
				}
				_dist = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fade")] 
		public CFloat Fade
		{
			get
			{
				if (_fade == null)
				{
					_fade = (CFloat) CR2WTypeManager.Create("Float", "fade", cr2w, this);
				}
				return _fade;
			}
			set
			{
				if (_fade == value)
				{
					return;
				}
				_fade = value;
				PropertySet(this);
			}
		}

		public audioReverbCrossoverParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
