using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialParameterMultilayerMask : CMaterialParameter
	{
		private rRef<Multilayer_Mask> _mask;

		[Ordinal(2)] 
		[RED("mask")] 
		public rRef<Multilayer_Mask> Mask
		{
			get
			{
				if (_mask == null)
				{
					_mask = (rRef<Multilayer_Mask>) CR2WTypeManager.Create("rRef:Multilayer_Mask", "mask", cr2w, this);
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

		public CMaterialParameterMultilayerMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
