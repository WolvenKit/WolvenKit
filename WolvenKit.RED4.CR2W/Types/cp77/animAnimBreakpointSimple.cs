using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimBreakpointSimple : animIAnimBreakpoint
	{
		private CUInt32 _hitCount;

		[Ordinal(1)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get
			{
				if (_hitCount == null)
				{
					_hitCount = (CUInt32) CR2WTypeManager.Create("Uint32", "hitCount", cr2w, this);
				}
				return _hitCount;
			}
			set
			{
				if (_hitCount == value)
				{
					return;
				}
				_hitCount = value;
				PropertySet(this);
			}
		}

		public animAnimBreakpointSimple(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
