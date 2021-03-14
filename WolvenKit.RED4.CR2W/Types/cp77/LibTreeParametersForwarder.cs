using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeParametersForwarder : CVariable
	{
		private CArray<CUInt32> _overrides;

		[Ordinal(0)] 
		[RED("overrides")] 
		public CArray<CUInt32> Overrides
		{
			get
			{
				if (_overrides == null)
				{
					_overrides = (CArray<CUInt32>) CR2WTypeManager.Create("array:Uint32", "overrides", cr2w, this);
				}
				return _overrides;
			}
			set
			{
				if (_overrides == value)
				{
					return;
				}
				_overrides = value;
				PropertySet(this);
			}
		}

		public LibTreeParametersForwarder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
