using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnlocSignature : CVariable
	{
		private CUInt64 _val;

		[Ordinal(0)] 
		[RED("val")] 
		public CUInt64 Val
		{
			get
			{
				if (_val == null)
				{
					_val = (CUInt64) CR2WTypeManager.Create("Uint64", "val", cr2w, this);
				}
				return _val;
			}
			set
			{
				if (_val == value)
				{
					return;
				}
				_val = value;
				PropertySet(this);
			}
		}

		public scnlocSignature(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
