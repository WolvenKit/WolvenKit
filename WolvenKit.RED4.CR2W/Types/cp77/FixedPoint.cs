using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FixedPoint : CVariable
	{
		private CInt32 _bits;

		[Ordinal(0)] 
		[RED("Bits")] 
		public CInt32 Bits
		{
			get
			{
				if (_bits == null)
				{
					_bits = (CInt32) CR2WTypeManager.Create("Int32", "Bits", cr2w, this);
				}
				return _bits;
			}
			set
			{
				if (_bits == value)
				{
					return;
				}
				_bits = value;
				PropertySet(this);
			}
		}

		public FixedPoint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
