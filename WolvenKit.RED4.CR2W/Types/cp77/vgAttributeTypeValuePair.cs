using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vgAttributeTypeValuePair : ISerializable
	{
		private CEnum<vgEStyleAttributeType> _pe;
		private CVariant _lue;

		[Ordinal(0)] 
		[RED("pe")] 
		public CEnum<vgEStyleAttributeType> Pe
		{
			get => GetProperty(ref _pe);
			set => SetProperty(ref _pe, value);
		}

		[Ordinal(1)] 
		[RED("lue")] 
		public CVariant Lue
		{
			get => GetProperty(ref _lue);
			set => SetProperty(ref _lue, value);
		}

		public vgAttributeTypeValuePair(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
