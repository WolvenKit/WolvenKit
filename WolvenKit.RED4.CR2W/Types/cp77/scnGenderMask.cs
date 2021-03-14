using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnGenderMask : CVariable
	{
		private CUInt8 _mask;

		[Ordinal(0)] 
		[RED("mask")] 
		public CUInt8 Mask
		{
			get
			{
				if (_mask == null)
				{
					_mask = (CUInt8) CR2WTypeManager.Create("Uint8", "mask", cr2w, this);
				}
				return _mask;
			}
			set
			{
				if (_mask == value)
				{
					return;
				}
				_mask = value;
				PropertySet(this);
			}
		}

		public scnGenderMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
