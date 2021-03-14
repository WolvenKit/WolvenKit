using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navSerializableSplineProgression : CVariable
	{
		private CUInt32 _sectionIdx;
		private CFloat _alpha;

		[Ordinal(0)] 
		[RED("sectionIdx")] 
		public CUInt32 SectionIdx
		{
			get
			{
				if (_sectionIdx == null)
				{
					_sectionIdx = (CUInt32) CR2WTypeManager.Create("Uint32", "sectionIdx", cr2w, this);
				}
				return _sectionIdx;
			}
			set
			{
				if (_sectionIdx == value)
				{
					return;
				}
				_sectionIdx = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("alpha")] 
		public CFloat Alpha
		{
			get
			{
				if (_alpha == null)
				{
					_alpha = (CFloat) CR2WTypeManager.Create("Float", "alpha", cr2w, this);
				}
				return _alpha;
			}
			set
			{
				if (_alpha == value)
				{
					return;
				}
				_alpha = value;
				PropertySet(this);
			}
		}

		public navSerializableSplineProgression(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
