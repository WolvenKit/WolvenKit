using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceClearance : IScriptable
	{
		private CInt32 _min;
		private CInt32 _max;

		[Ordinal(0)] 
		[RED("min")] 
		public CInt32 Min
		{
			get
			{
				if (_min == null)
				{
					_min = (CInt32) CR2WTypeManager.Create("Int32", "min", cr2w, this);
				}
				return _min;
			}
			set
			{
				if (_min == value)
				{
					return;
				}
				_min = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CInt32 Max
		{
			get
			{
				if (_max == null)
				{
					_max = (CInt32) CR2WTypeManager.Create("Int32", "max", cr2w, this);
				}
				return _max;
			}
			set
			{
				if (_max == value)
				{
					return;
				}
				_max = value;
				PropertySet(this);
			}
		}

		public gamedeviceClearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
