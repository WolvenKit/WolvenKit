using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class netTime : CVariable
	{
		private CUInt64 _milliSecs;

		[Ordinal(0)] 
		[RED("milliSecs")] 
		public CUInt64 MilliSecs
		{
			get
			{
				if (_milliSecs == null)
				{
					_milliSecs = (CUInt64) CR2WTypeManager.Create("Uint64", "milliSecs", cr2w, this);
				}
				return _milliSecs;
			}
			set
			{
				if (_milliSecs == value)
				{
					return;
				}
				_milliSecs = value;
				PropertySet(this);
			}
		}

		public netTime(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
