using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgBaseVectorGraphicShape : ISerializable
	{
		private CMatrix _calTransform;
		private CHandle<vgVectorGraphicStyle> _yle;

		[Ordinal(0)] 
		[RED("calTransform")] 
		public CMatrix CalTransform
		{
			get
			{
				if (_calTransform == null)
				{
					_calTransform = (CMatrix) CR2WTypeManager.Create("Matrix", "calTransform", cr2w, this);
				}
				return _calTransform;
			}
			set
			{
				if (_calTransform == value)
				{
					return;
				}
				_calTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("yle")] 
		public CHandle<vgVectorGraphicStyle> Yle
		{
			get
			{
				if (_yle == null)
				{
					_yle = (CHandle<vgVectorGraphicStyle>) CR2WTypeManager.Create("handle:vgVectorGraphicStyle", "yle", cr2w, this);
				}
				return _yle;
			}
			set
			{
				if (_yle == value)
				{
					return;
				}
				_yle = value;
				PropertySet(this);
			}
		}

		public vgBaseVectorGraphicShape(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
