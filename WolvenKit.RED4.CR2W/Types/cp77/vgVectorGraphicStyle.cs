using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgVectorGraphicStyle : ISerializable
	{
		private CArray<vgAttributeTypeValuePair> _attributes;

		[Ordinal(0)] 
		[RED("attributes")] 
		public CArray<vgAttributeTypeValuePair> Attributes
		{
			get
			{
				if (_attributes == null)
				{
					_attributes = (CArray<vgAttributeTypeValuePair>) CR2WTypeManager.Create("array:vgAttributeTypeValuePair", "attributes", cr2w, this);
				}
				return _attributes;
			}
			set
			{
				if (_attributes == value)
				{
					return;
				}
				_attributes = value;
				PropertySet(this);
			}
		}

		public vgVectorGraphicStyle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
