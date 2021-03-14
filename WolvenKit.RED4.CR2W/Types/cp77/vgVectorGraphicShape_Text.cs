using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicShape_Text : vgBaseVectorGraphicShape
	{
		private CString _xt;

		[Ordinal(2)] 
		[RED("xt")] 
		public CString Xt
		{
			get
			{
				if (_xt == null)
				{
					_xt = (CString) CR2WTypeManager.Create("String", "xt", cr2w, this);
				}
				return _xt;
			}
			set
			{
				if (_xt == value)
				{
					return;
				}
				_xt = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicShape_Text(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
