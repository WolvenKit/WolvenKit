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
			get => GetProperty(ref _attributes);
			set => SetProperty(ref _attributes, value);
		}

		public vgVectorGraphicStyle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
