using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FeatureFlagsMask : CVariable
	{
		private CUInt64 _flags;

		[Ordinal(0)] 
		[RED("flags")] 
		public CUInt64 Flags
		{
			get
			{
				if (_flags == null)
				{
					_flags = (CUInt64) CR2WTypeManager.Create("Uint64", "flags", cr2w, this);
				}
				return _flags;
			}
			set
			{
				if (_flags == value)
				{
					return;
				}
				_flags = value;
				PropertySet(this);
			}
		}

		public FeatureFlagsMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
