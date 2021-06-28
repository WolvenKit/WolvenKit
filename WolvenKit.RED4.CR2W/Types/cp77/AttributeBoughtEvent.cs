using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttributeBoughtEvent : redEvent
	{
		private CEnum<gamedataStatType> _attributeType;

		[Ordinal(0)] 
		[RED("attributeType")] 
		public CEnum<gamedataStatType> AttributeType
		{
			get => GetProperty(ref _attributeType);
			set => SetProperty(ref _attributeType, value);
		}

		public AttributeBoughtEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
